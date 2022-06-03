using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAPI.DTO
{
    public partial class GetHLECaseResponseDTO
    {
        public string AccountOwnerName { get; set; }
        public string ApplicationSource { get; set; }
        public string AppliedHelpSearchString { get; set; }
        public bool CaExpandAccountSection { get; set; }
        public bool CaExpandContactSection { get; set; }
        public bool CaExpandCustomerSection { get; set; }
        public Guid CifNbr { get; set; }
        public long CifNbrText { get; set; }
        public string ContactName { get; set; }
        public string ContactNameNoSalutation { get; set; }
        public string FullName { get; set; }
        public string HelpSearchString { get; set; }
        public bool IsTabNavGadget { get; set; }
        public string Lob { get; set; }
        public string PxApplication { get; set; }
        public string PxApplicationVersion { get; set; }
        public DateTimeOffset PxCommitDateTime { get; set; }
        public long PxCoveredCount { get; set; }
        public long PxCoveredCountOpen { get; set; }
        public long PxCoveredCountUnsatisfied { get; set; }
        public DateTimeOffset PxCreateDateTime { get; set; }
        public string PxCreateOperator { get; set; }
        public string PxCreateOpName { get; set; }
        public string PxCreateSystemId { get; set; }
        public string PxCurrentStage { get; set; }
        public string PxCurrentStageLabel { get; set; }
        public string PxCurrentStageSubscript { get; set; }
        public long PxExternalSystemUpdateCount { get; set; }
        public string PxInsName { get; set; }
        public string PxObjClass { get; set; }
        public DateTimeOffset PxSaveDateTime { get; set; }
        public long PxUpdateCounter { get; set; }
        public DateTimeOffset PxUpdateDateTime { get; set; }
        public string PxUpdateOperator { get; set; }
        public string PxUpdateOpName { get; set; }
        public string PxUpdateOrgUnit { get; set; }
        public string PxUpdateSystemId { get; set; }
        public long PxUrgencyPartyTotal { get; set; }
        public long PxUrgencyWork { get; set; }
        public long PxUrgencyWorkClass { get; set; }
        public long PxUrgencyWorkSla { get; set; }
        public long PxUrgencyWorkStageSla { get; set; }
        public DateTimeOffset PyAgeFromDate { get; set; }
        public string PyCalendar { get; set; }
        public string PyConfirmationNote { get; set; }
        public string PyCustomerName { get; set; }
        public string PyElapsedCustomerUnsatisfied { get; set; }
        public long PyElapsedStatusNew { get; set; }
        public string PyElapsedStatusOpen { get; set; }
        public long PyElapsedStatusPending { get; set; }
        public string PyFlowKey { get; set; }
        public string PyFlowName { get; set; }
        public string PyFolderType { get; set; }
        public string PyId { get; set; }
        public string PyLabel { get; set; }
        public string PyLabelOld { get; set; }
        public long PyNextEmailThreadId { get; set; }
        public string PyNote { get; set; }
        public string PyNotifyQuickStream { get; set; }
        public string PyOrigOrg { get; set; }
        public string PyOrigUserId { get; set; }
        public string PyOwnerOrg { get; set; }
        public bool PyPushNotificationsEnabled { get; set; }
        public string PyResolvedDivision { get; set; }
        public string PyResolvedOrg { get; set; }
        public string PyResolvedOrgUnit { get; set; }
        public string PyResolvedTime { get; set; }
        public DateTimeOffset PyResolvedTimestamp { get; set; }
        public string PyResolvedUserDivision { get; set; }
        public string PyResolvedUserId { get; set; }
        public string PyResolvedUserWorkgroup { get; set; }
        public DateTimeOffset PySatisfactionChangeTimestamp { get; set; }
        public DateTimeOffset PySlaAction { get; set; }
        public string PySlaName { get; set; }
        public string PyStatusCustomerSat { get; set; }
        public string PyStatusWork { get; set; }
        public string PyStatusWorkOld { get; set; }
        public DateTimeOffset PyStatusWorkTimestamp { get; set; }
        public bool PyTemporaryObject { get; set; }
        public string PyWorkBasketToAssign { get; set; }
        public string PyWorkIdPrefix { get; set; }
        public string PyWorkPartiesRule { get; set; }
        public long PzIndexCount { get; set; }
        public string PzInsKey { get; set; }
        public string PzLoadTime { get; set; }
        public string PzPageNameHash { get; set; }
        public string RdeDay { get; set; }
        public string RdeMonth { get; set; }
        public string RdeQuarter { get; set; }
        public string RdeWeek { get; set; }
        public long RdeYear { get; set; }
        public string Region { get; set; }
        public Guid RequestId { get; set; }
        public bool ServiceEventCaptured { get; set; }
        public bool ShowDuration { get; set; }
        public string Type { get; set; }
        public string WorkingTeam { get; set; }
        public ApplicationDetails ApplicationDetails { get; set; }
        public AppointmentDetails AppointmentDetails { get; set; }
        public CaseOrigDetails CaseOrigDetails { get; set; }
        public Contact Contact { get; set; }
        public OnyxNoteDetails OnyxNoteDetails { get; set; }
        public List<OnyxNotesHistory> OnyxNotesHistory { get; set; }
        public PxFlow PxFlow { get; set; }
        public List<PxResolveSummary> PxResolveSummary { get; set; }
        public List<PxStageHistory> PxStageHistory { get; set; }
        public List<object> PxSystemUpdateDetailsList { get; set; }
        public List<string> PxTickets { get; set; }
        public List<object> PyAttachmentCategories { get; set; }
        public PyWorkParty PyWorkParty { get; set; }
        public List<object> SkillsList { get; set; }
    }

    public partial class ApplicationDetails
    {
        public string ApplicantType { get; set; }
        public string ApplicationSource { get; set; }
        public string CaseType { get; set; }
        public long DepositAmount { get; set; }
        public string DepositType { get; set; }
        public string EnquiryType { get; set; }
        public DateTimeOffset EventDateTime { get; set; }
        public string HandoverType { get; set; }
        public string OriginationChannel { get; set; }
        public string Purpose { get; set; }
        public string PxObjClass { get; set; }
        public string RequestedAction { get; set; }
        public Applicant Applicant { get; set; }
    }

    public partial class Applicant
    {
        public Primary Primary { get; set; }
    }

    public partial class Primary
    {
        public Guid CifNbr { get; set; }
        public long CifNbrText { get; set; }
        public string ContactPreference { get; set; }
        public bool ExistingCustomer { get; set; }
        public string MiddleName { get; set; }
        public string PreferredPhone { get; set; }
        public string PxObjClass { get; set; }
        public string PxSubscript { get; set; }
        public string PyFirstName { get; set; }
        public string PyLastName { get; set; }
        public string PyTitle { get; set; }
    }

    public partial class AppointmentDetails
    {
        public string AdditionalInfo { get; set; }
        public DateTimeOffset AppointmentDateTime { get; set; }
        public string AppointmentTime { get; set; }
        public string HandingOverToUserName { get; set; }
        public long LenderPersonnelNumber { get; set; }
        public string PreferedAppointmentMethod { get; set; }
        public string PxObjClass { get; set; }
        public long SubmittedBy { get; set; }
        public string SubmittedByUserName { get; set; }
    }

    public partial class CaseOrigDetails
    {
        public string OrigAssignedTo { get; set; }
        public string OrigAssignedType { get; set; }
        public string OrigRegion { get; set; }
        public string PxObjClass { get; set; }
        public string PzIndexOwnerKey { get; set; }
        public CaseOrigDetailsPzIndexes PzIndexes { get; set; }
    }

    public partial class CaseOrigDetailsPzIndexes
    {
        public long HleCaseOriginDetails { get; set; }
    }

    public partial class Contact
    {
        public string PxObjClass { get; set; }
    }

    public partial class OnyxNoteDetails
    {
        public string AssignedTo { get; set; }
        public string CategoryRefId { get; set; }
        public long Count { get; set; }
        public string DocumentType { get; set; }
        public long NoteId { get; set; }
        public string OwnerTypeRefId { get; set; }
        public string PxObjClass { get; set; }
        public string PyStatusMessage { get; set; }
        public string PzIndexOwnerKey { get; set; }
        public string SourceRefId { get; set; }
        public string TypeRefId { get; set; }
        public OnyxNoteDetailsPzIndexes PzIndexes { get; set; }
    }

    public partial class OnyxNoteDetailsPzIndexes
    {
        public long OnyxNoteDetails { get; set; }
    }

    public partial class OnyxNotesHistory
    {
        public string ApplicationName { get; set; }
        public string CaseId { get; set; }
        public Guid Id { get; set; }
        public long NoteId { get; set; }
        public string OnyxComments { get; set; }
        public string OnyxStatus { get; set; }
        public DateTimeOffset PxCreateDateTime { get; set; }
        public string PxCreateOpName { get; set; }
        public string PxObjClass { get; set; }
        public long PxUpdateSystemId { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }

    public partial class PxFlow
    {
    }

    public partial class PxResolveSummary
    {
        public string PxObjClass { get; set; }
        public string PxResolvedDivision { get; set; }
        public string PxResolvedNote { get; set; }
        public string PxResolvedOrg { get; set; }
        public string PxResolvedOrgUnit { get; set; }
        public string PxResolvedStatus { get; set; }
        public DateTimeOffset PxResolvedTimestamp { get; set; }
        public string PxResolvedUserDivision { get; set; }
        public string PxResolvedUserId { get; set; }
        public string PxResolvedUserName { get; set; }
        public string PxResolvedUserWorkgroup { get; set; }
    }

    public partial class PxStageHistory
    {
        public string PxCompletedBy { get; set; }
        public DateTimeOffset PxCompletedStageTime { get; set; }
        public DateTimeOffset PxEnterStageTime { get; set; }
        public string PxObjClass { get; set; }
        public string PxStageId { get; set; }
        public string PxStageName { get; set; }
        public string PxStageType { get; set; }
        public string PxSubscript { get; set; }
        public string PxWentTo { get; set; }
        public List<PxProcess> PxProcesses { get; set; }
        public string PxCameFrom { get; set; }
    }

    public partial class PxProcess
    {
        public string PxCompletedBy { get; set; }
        public DateTimeOffset PxCompletedTime { get; set; }
        public string PxFlowId { get; set; }
        public string PxIsComplete { get; set; }
        public bool PxIsOptional { get; set; }
        public string PxObjClass { get; set; }
        public string PxProcessName { get; set; }
        public string PxStartedBy { get; set; }
        public DateTimeOffset PxStartTime { get; set; }
        public string PxSubscript { get; set; }
        public string PyLabel { get; set; }
        public List<PxStep> PxSteps { get; set; }
    }

    public partial class PxStep
    {
        public string PxObjClass { get; set; }
        public string PxStepId { get; set; }
        public string PxStepType { get; set; }
        public string PyLabel { get; set; }
    }

    public partial class PyWorkParty
    {
        public AccountOwner AccountOwner { get; set; }
        public Customer Customer { get; set; }
    }

    public partial class AccountOwner
    {
        public string PxObjClass { get; set; }
        public string PxSubscript { get; set; }
        public string PzIndexOwnerKey { get; set; }
        public AccountOwnerPzIndexes PzIndexes { get; set; }
    }

    public partial class AccountOwnerPzIndexes
    {
        public long FinWorkParties { get; set; }
        public long PartyUri { get; set; }
    }

    public partial class Customer
    {
        public long Age { get; set; }
        public Guid CifNbr { get; set; }
        public long CifNbrText { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PortfolioManager { get; set; }
        public string PreferredPhone { get; set; }
        public string Prefix { get; set; }
        public string PxObjClass { get; set; }
        public string PxSubscript { get; set; }
        public string PyAddress { get; set; }
        public string PyCity { get; set; }
        public string PyEmail { get; set; }
        public string PyFirstName { get; set; }
        public string PyHomePhone { get; set; }
        public string PyLastName { get; set; }
        public string PyMobilePhone { get; set; }
        public string PyNote { get; set; }
        public long PyPostalCode { get; set; }
        public string PzIndexOwnerKey { get; set; }
        public string TaxIdNbr { get; set; }
        public AccountOwnerPzIndexes PzIndexes { get; set; }
    }
}

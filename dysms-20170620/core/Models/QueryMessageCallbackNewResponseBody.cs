// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryMessageCallbackNewResponseBody : TeaModel {
        [NameInMap("AiccsCallMidRecordCallbackUrl")]
        [Validation(Required=false)]
        public string AiccsCallMidRecordCallbackUrl { get; set; }

        [NameInMap("AiccsCallRecordCallbackUrl")]
        [Validation(Required=false)]
        public string AiccsCallRecordCallbackUrl { get; set; }

        [NameInMap("AiccsSentRecordCallbackUrl")]
        [Validation(Required=false)]
        public string AiccsSentRecordCallbackUrl { get; set; }

        [NameInMap("ArtcCdrReportCallBackUrl")]
        [Validation(Required=false)]
        public string ArtcCdrReportCallBackUrl { get; set; }

        [NameInMap("ArtcTempStatusReportCallBackUrl")]
        [Validation(Required=false)]
        public string ArtcTempStatusReportCallBackUrl { get; set; }

        [NameInMap("CardDyncResCallbackUrl")]
        [Validation(Required=false)]
        public string CardDyncResCallbackUrl { get; set; }

        [NameInMap("CardTemplateCallBackUrl")]
        [Validation(Required=false)]
        public string CardTemplateCallBackUrl { get; set; }

        [NameInMap("CardVerderCallBackUrl")]
        [Validation(Required=false)]
        public string CardVerderCallBackUrl { get; set; }

        [NameInMap("DcdpCallbackUrl")]
        [Validation(Required=false)]
        public string DcdpCallbackUrl { get; set; }

        [NameInMap("DigitSmsTemplateCallBackUrl")]
        [Validation(Required=false)]
        public string DigitSmsTemplateCallBackUrl { get; set; }

        [NameInMap("GlobeSmsReportCallback")]
        [Validation(Required=false)]
        public bool? GlobeSmsReportCallback { get; set; }

        [NameInMap("GlobeSmsReportCallbackUrl")]
        [Validation(Required=false)]
        public string GlobeSmsReportCallbackUrl { get; set; }

        [NameInMap("IsAiccsCallMidRecord")]
        [Validation(Required=false)]
        public bool? IsAiccsCallMidRecord { get; set; }

        [NameInMap("IsAiccsCallRecord")]
        [Validation(Required=false)]
        public bool? IsAiccsCallRecord { get; set; }

        [NameInMap("IsAiccsSentRecord")]
        [Validation(Required=false)]
        public bool? IsAiccsSentRecord { get; set; }

        [NameInMap("IsArtcCdrReportCallBack")]
        [Validation(Required=false)]
        public bool? IsArtcCdrReportCallBack { get; set; }

        [NameInMap("IsArtcTempStatusReportCallBack")]
        [Validation(Required=false)]
        public bool? IsArtcTempStatusReportCallBack { get; set; }

        [NameInMap("IsDcdpCallback")]
        [Validation(Required=false)]
        public bool? IsDcdpCallback { get; set; }

        [NameInMap("IsDigitSmsTemplateCallBack")]
        [Validation(Required=false)]
        public bool? IsDigitSmsTemplateCallBack { get; set; }

        [NameInMap("IsGlobeSmsReportCallback")]
        [Validation(Required=false)]
        public bool? IsGlobeSmsReportCallback { get; set; }

        [NameInMap("IsOpened")]
        [Validation(Required=false)]
        public bool? IsOpened { get; set; }

        [NameInMap("IsSecretReportMessageCallback")]
        [Validation(Required=false)]
        public bool? IsSecretReportMessageCallback { get; set; }

        [NameInMap("IsSecretSmsMessageCallback")]
        [Validation(Required=false)]
        public bool? IsSecretSmsMessageCallback { get; set; }

        [NameInMap("IsSignReportCallback")]
        [Validation(Required=false)]
        public bool? IsSignReportCallback { get; set; }

        [NameInMap("IsSmartCallAsrCallBack")]
        [Validation(Required=false)]
        public bool? IsSmartCallAsrCallBack { get; set; }

        [NameInMap("IsSmsReportMessageCallback")]
        [Validation(Required=false)]
        public bool? IsSmsReportMessageCallback { get; set; }

        [NameInMap("IsSmsUpMessageCallback")]
        [Validation(Required=false)]
        public bool? IsSmsUpMessageCallback { get; set; }

        [NameInMap("IsTemplateReportCallback")]
        [Validation(Required=false)]
        public bool? IsTemplateReportCallback { get; set; }

        [NameInMap("IsVoiceAsrCallBack")]
        [Validation(Required=false)]
        public bool? IsVoiceAsrCallBack { get; set; }

        [NameInMap("IsVoiceCallMidStateCallBack")]
        [Validation(Required=false)]
        public bool? IsVoiceCallMidStateCallBack { get; set; }

        [NameInMap("IsVoiceCallRecordCallBack")]
        [Validation(Required=false)]
        public bool? IsVoiceCallRecordCallBack { get; set; }

        [NameInMap("IsVoiceRecordingCallBack")]
        [Validation(Required=false)]
        public bool? IsVoiceRecordingCallBack { get; set; }

        [NameInMap("ReportCallbackUrl")]
        [Validation(Required=false)]
        public string ReportCallbackUrl { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretCallbackUrl")]
        [Validation(Required=false)]
        public string SecretCallbackUrl { get; set; }

        [NameInMap("SecretSmsCallbackUrl")]
        [Validation(Required=false)]
        public string SecretSmsCallbackUrl { get; set; }

        [NameInMap("ShortLinkCallBackUrl")]
        [Validation(Required=false)]
        public string ShortLinkCallBackUrl { get; set; }

        [NameInMap("SignReportCallbackUrl")]
        [Validation(Required=false)]
        public string SignReportCallbackUrl { get; set; }

        [NameInMap("SmartCallAsrCallBackUrl")]
        [Validation(Required=false)]
        public string SmartCallAsrCallBackUrl { get; set; }

        [NameInMap("TemplateReportCallbackUrl")]
        [Validation(Required=false)]
        public string TemplateReportCallbackUrl { get; set; }

        [NameInMap("UpCallbackUrl")]
        [Validation(Required=false)]
        public string UpCallbackUrl { get; set; }

        [NameInMap("VoiceAsrCallBackUrl")]
        [Validation(Required=false)]
        public string VoiceAsrCallBackUrl { get; set; }

        [NameInMap("VoiceCallMidStateCallBackUrl")]
        [Validation(Required=false)]
        public string VoiceCallMidStateCallBackUrl { get; set; }

        [NameInMap("VoiceCallRecordCallBackUrl")]
        [Validation(Required=false)]
        public string VoiceCallRecordCallBackUrl { get; set; }

        [NameInMap("VoiceRecordingCallBackUrl")]
        [Validation(Required=false)]
        public string VoiceRecordingCallBackUrl { get; set; }

    }

}

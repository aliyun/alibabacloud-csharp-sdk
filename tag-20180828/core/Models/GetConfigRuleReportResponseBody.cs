// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetConfigRuleReportResponseBody : TeaModel {
        /// <summary>
        /// The basic information of the resource non-compliance report that is last generated.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConfigRuleReportResponseBodyData Data { get; set; }
        public class GetConfigRuleReportResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the report was generated. This value is a UNIX timestamp.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The ID of the report.
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// The ID of the object.
            /// 
            /// >  This parameter is returned if you set the `TargetType` and `TargetId` parameters in the current request to the same values as the parameters that are configured when you call the [GenerateConfigRuleReport](~~433313~~) operation to generate the report.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The type of the object. Valid values:
            /// 
            /// *   USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.
            /// *   ROOT: the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// *   FOLDER: a folder other than the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// *   ACCOUNT: a member in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// 
            /// >  This parameter is returned if you set the `TargetType` and `TargetId` parameters in the current request to the same values as the parameters that are configured when you call the [GenerateConfigRuleReport](~~433313~~) operation to generate the report.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request is successful.
        /// *   false: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

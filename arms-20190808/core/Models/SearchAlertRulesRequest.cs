// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertRulesRequest : TeaModel {
        [NameInMap("AlertRuleId")]
        [Validation(Required=false)]
        public string AlertRuleId { get; set; }

        /// <summary>
        /// The type of the application that is associated with the alert rule. Valid values:
        /// 
        /// *   `TRACE`: application
        /// *   `RETCODE`: browser
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The page number of the page to return. Default value: `1`.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return per page. Default value: `10`.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The process identifier (PID) of the application that is associated with the alert rule. For more information about how to obtain the PID, see [Obtain the PID of an application](https://help.aliyun.com/document_detail/186100.html?spm=a2c4g.11186623.6.792.1b50654cqcDPyk#title-imy-7gj-qhr).
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The region ID of the alert data. For more information about the mappings between **RegionId** and **SystemRegionId**, see the detailed description below the table.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The region ID of the alert rule. For more information about the mappings between **RegionId** and **SystemRegionId**, see the detailed description below the table.
        /// </summary>
        [NameInMap("SystemRegionId")]
        [Validation(Required=false)]
        public string SystemRegionId { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<SearchAlertRulesRequestTags> Tags { get; set; }
        public class SearchAlertRulesRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag. The following system preset fields are provided:
            /// 
            /// *   traceId: the ID of the trace.
            /// *   serverApp: the name of the server application.
            /// *   clientApp: the name of the client application.
            /// *   service: the name of the operation.
            /// *   rpc: the type of the call.
            /// *   msOfSpan: the duration exceeds a specific value.
            /// *   clientIp: the IP address of the client.
            /// *   serverIp: the IP address of the server.
            /// *   isError: specifies whether the call is abnormal.
            /// *   hasTprof: contains only thread profiling.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The alert rule name.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The alert rule type. Valid values:
        /// 
        /// *   `1`: custom alert rules that are used to monitor drill-down data sets
        /// *   `3`: custom alert rules that are used to monitor tiled data sets
        /// *   `4`: alert rules that are used to monitor the browser, including the default frontend alert rules
        /// *   `5`: alert rules that are used to monitor applications, including the default application alert rules
        /// *   `6`: the default browser alert rules
        /// *   `7`: the default application alert rules
        /// *   `8`: Tracing Analysis alert rules
        /// *   `101`: Prometheus alert rules
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

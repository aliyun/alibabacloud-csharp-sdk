// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteTraceAppRequest : TeaModel {
        /// <summary>
        /// The ID of the application that you want to delete. You can call the SearchTraceAppByName operation to query the application ID. For more information, see [SearchTraceAppByName](https://help.aliyun.com/document_detail/130676.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The reason(s) to delete application.
        /// </summary>
        [NameInMap("DeleteReason")]
        [Validation(Required=false)]
        public DeleteTraceAppRequestDeleteReason DeleteReason { get; set; }
        public class DeleteTraceAppRequestDeleteReason : TeaModel {
            /// <summary>
            /// Reasons Ids.
            /// </summary>
            [NameInMap("ReasonIds")]
            [Validation(Required=false)]
            public List<DeleteTraceAppRequestDeleteReasonReasonIds> ReasonIds { get; set; }
            public class DeleteTraceAppRequestDeleteReasonReasonIds : TeaModel {
                /// <summary>
                /// The ID of the reason for deletion.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// A description of the reason for removal.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// Additional remarks when none of the reasons for removal provided are met.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// The PID of the application. For more information about how to query the PID, see [QueryMetricByPage](https://www.alibabacloud.com/help/zh/doc-detail/186100.htm?spm=a2cdw.13409063.0.0.7a72281f0bkTfx#title-imy-7gj-qhr).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The ID of the region in which the application is located.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the application that you want to delete. You can call the SearchTraceAppByName operation to query the application type. For more information, see [SearchTraceAppByName](https://help.aliyun.com/document_detail/130676.html). Valid values:
        /// 
        /// *   `TRACE`: Application Monitoring
        /// *   `RETCODE`: frontend monitoring
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

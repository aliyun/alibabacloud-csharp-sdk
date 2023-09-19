// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateSiteMonitorResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned result.
        /// 
        /// If a site monitoring task is created, the result is returned. If a site monitoring task fails to be created, no result is returned.
        /// </summary>
        [NameInMap("CreateResultList")]
        [Validation(Required=false)]
        public CreateSiteMonitorResponseBodyCreateResultList CreateResultList { get; set; }
        public class CreateSiteMonitorResponseBodyCreateResultList : TeaModel {
            [NameInMap("CreateResultList")]
            [Validation(Required=false)]
            public List<CreateSiteMonitorResponseBodyCreateResultListCreateResultList> CreateResultList { get; set; }
            public class CreateSiteMonitorResponseBodyCreateResultListCreateResultList : TeaModel {
                /// <summary>
                /// The ID of the site monitoring task.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The name of the site monitoring task.
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

        }

        /// <summary>
        /// The result of the site monitoring task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSiteMonitorResponseBodyData Data { get; set; }
        public class CreateSiteMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// The result that is returned after you associate the existing alert rule with the site monitoring task.
            /// </summary>
            [NameInMap("AttachAlertResult")]
            [Validation(Required=false)]
            public CreateSiteMonitorResponseBodyDataAttachAlertResult AttachAlertResult { get; set; }
            public class CreateSiteMonitorResponseBodyDataAttachAlertResult : TeaModel {
                [NameInMap("Contact")]
                [Validation(Required=false)]
                public List<CreateSiteMonitorResponseBodyDataAttachAlertResultContact> Contact { get; set; }
                public class CreateSiteMonitorResponseBodyDataAttachAlertResultContact : TeaModel {
                    /// <summary>
                    /// The status code that is returned after you associate the existing alert rule with the site monitoring task.
                    /// 
                    /// >  The status code 200 indicates that the request was successful.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The message that is returned after you associate the existing alert rule with the site monitoring task.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The ID of the request that was sent to associate the existing alert rule with the site monitoring task.
                    /// </summary>
                    [NameInMap("RequestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                    /// <summary>
                    /// The ID of the alert rule.
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                    /// <summary>
                    /// Indicates whether the existing alert rule was associated with the site monitoring task. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public string Success { get; set; }

                }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

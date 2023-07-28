// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetApplicationGroupResponseBody : TeaModel {
        /// <summary>
        /// The details of the application group.
        /// </summary>
        [NameInMap("ApplicationGroup")]
        [Validation(Required=false)]
        public GetApplicationGroupResponseBodyApplicationGroup ApplicationGroup { get; set; }
        public class GetApplicationGroupResponseBodyApplicationGroup : TeaModel {
            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The ID of the application group in CloudMonitor.
            /// </summary>
            [NameInMap("CmsGroupId")]
            [Validation(Required=false)]
            public string CmsGroupId { get; set; }

            /// <summary>
            /// The time when the application group was created.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The output of the deployment result.
            /// </summary>
            [NameInMap("DeployOutputs")]
            [Validation(Required=false)]
            public string DeployOutputs { get; set; }

            /// <summary>
            /// The configuration information of the application group.
            /// </summary>
            [NameInMap("DeployParameters")]
            [Validation(Required=false)]
            public string DeployParameters { get; set; }

            /// <summary>
            /// The ID of the region in which you deploy the application group.
            /// </summary>
            [NameInMap("DeployRegionId")]
            [Validation(Required=false)]
            public string DeployRegionId { get; set; }

            /// <summary>
            /// The description of the application group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("ImportTagKey")]
            [Validation(Required=false)]
            public string ImportTagKey { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("ImportTagValue")]
            [Validation(Required=false)]
            public string ImportTagValue { get; set; }

            /// <summary>
            /// The name of the application group.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The creation progress of the application instance.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The state of the application group.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The state information of the application group.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// The time when the application group was last modified.
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

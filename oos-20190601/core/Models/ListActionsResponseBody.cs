// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListActionsResponseBody : TeaModel {
        /// <summary>
        /// The details of the actions.
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<ListActionsResponseBodyActions> Actions { get; set; }
        public class ListActionsResponseBodyActions : TeaModel {
            /// <summary>
            /// The type of the action.
            /// 
            /// 1.  Atomic actions
            /// 
            ///     *   Atomic.API
            ///     *   Atomic.Trigger
            ///     *   Atomic.Control
            ///     *   Atomic.Embedded
            /// 
            /// 2.  Cloud product actions
            /// 
            ///     *   Product.ECS
            ///     *   Product.RDS
            ///     *   Product.VPC
            ///     *   Product.FC
            ///     *   ...
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// The time when the action was created.
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// The description of the action.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the action.
            /// </summary>
            [NameInMap("OOSActionName")]
            [Validation(Required=false)]
            public string OOSActionName { get; set; }

            /// <summary>
            /// The number of times that the action is used.
            /// </summary>
            [NameInMap("Popularity")]
            [Validation(Required=false)]
            public int? Popularity { get; set; }

            /// <summary>
            /// The parameters of the action.
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// The version of the template that corresponds to the action.
            /// 
            /// >  For atomic actions, this parameter is not returned.
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicTableRouteConfigResponseBody : TeaModel {
        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The routing algorithms.
        /// </summary>
        [NameInMap("LogicTableRouteConfigList")]
        [Validation(Required=false)]
        public ListLogicTableRouteConfigResponseBodyLogicTableRouteConfigList LogicTableRouteConfigList { get; set; }
        public class ListLogicTableRouteConfigResponseBodyLogicTableRouteConfigList : TeaModel {
            [NameInMap("LogicTableRouteConfig")]
            [Validation(Required=false)]
            public List<ListLogicTableRouteConfigResponseBodyLogicTableRouteConfigListLogicTableRouteConfig> LogicTableRouteConfig { get; set; }
            public class ListLogicTableRouteConfigResponseBodyLogicTableRouteConfigListLogicTableRouteConfig : TeaModel {
                /// <summary>
                /// The routing algorithm expression.
                /// </summary>
                [NameInMap("RouteExpr")]
                [Validation(Required=false)]
                public string RouteExpr { get; set; }

                /// <summary>
                /// The unique key of the routing algorithm.
                /// </summary>
                [NameInMap("RouteKey")]
                [Validation(Required=false)]
                public string RouteKey { get; set; }

                /// <summary>
                /// The ID of the logical table.
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public long? TableId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// - **true**: The request was successful.
        /// - **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicTableRouteConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingTableId</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TableId is mandatory for this action.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The routing algorithms.</para>
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
                /// <para>The routing algorithm expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#id#%16\t</para>
                /// </summary>
                [NameInMap("RouteExpr")]
                [Validation(Required=false)]
                public string RouteExpr { get; set; }

                /// <summary>
                /// <para>The unique key of the routing algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RouteKey")]
                [Validation(Required=false)]
                public string RouteKey { get; set; }

                /// <summary>
                /// <para>The ID of the logical table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4****</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public long? TableId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6A0D7D-B034-59F6-854C-32425AC6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

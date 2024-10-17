// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details about the tickets.</para>
        /// </summary>
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public ListOrdersResponseBodyOrders Orders { get; set; }
        public class ListOrdersResponseBodyOrders : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public List<ListOrdersResponseBodyOrdersOrder> Order { get; set; }
            public class ListOrdersResponseBodyOrdersOrder : TeaModel {
                /// <summary>
                /// <para>The remarks of the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The user who submitted the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Committer")]
                [Validation(Required=false)]
                public string Committer { get; set; }

                /// <summary>
                /// <para>The ID of the user who submitted the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("CommitterId")]
                [Validation(Required=false)]
                public long? CommitterId { get; set; }

                /// <summary>
                /// <para>The time when the ticket was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-08 11:15:46</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the ticket was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-08 11:27:45</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                /// <summary>
                /// <para>The ID of the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <para>The type of the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DC_COMMON</para>
                /// </summary>
                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

                /// <summary>
                /// <para>The status code of the ticket. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>fail</b>: The ticket fails to be executed.</description></item>
                /// <item><description><b>toaudit</b>: The ticket is waiting for approval.</description></item>
                /// <item><description><b>cancel</b>: The ticket is cancelled.</description></item>
                /// <item><description><b>processing</b>: The ticket is being executed.</description></item>
                /// <item><description><b>approved</b>: The ticket is approved.</description></item>
                /// <item><description><b>reject</b>: The ticket is rejected.</description></item>
                /// <item><description><b>success</b>: The ticket is executed.</description></item>
                /// <item><description><b>closed</b>: The ticket is closed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>The status description of the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>changed successfully</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>427688B8-ADFB-4C4E-9D45-EF5C1FD6E23D</para>
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

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

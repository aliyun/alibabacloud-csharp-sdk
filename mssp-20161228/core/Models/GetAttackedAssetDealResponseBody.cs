// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetAttackedAssetDealResponseBody : TeaModel {
        /// <summary>
        /// <para>Interface return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAttackedAssetDealResponseBodyData Data { get; set; }
        public class GetAttackedAssetDealResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Collection of attacked asset convergence trends.</para>
            /// </summary>
            [NameInMap("EcsTrendList")]
            [Validation(Required=false)]
            public List<GetAttackedAssetDealResponseBodyDataEcsTrendList> EcsTrendList { get; set; }
            public class GetAttackedAssetDealResponseBodyDataEcsTrendList : TeaModel {
                /// <summary>
                /// <para>Date point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202312或20231205</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>Number of processed items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DealCount")]
                [Validation(Required=false)]
                public long? DealCount { get; set; }

                /// <summary>
                /// <para>Number of discovered items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>暂时无值，有疑问请联系管理员</para>
                /// </summary>
                [NameInMap("FindCount")]
                [Validation(Required=false)]
                public long? FindCount { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E74F11C-B4A8-5774-962C-02003BA8504E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the query was successful.<br />
        /// <b>Enum values:</b></para>
        /// <list type="bullet">
        /// <item><description>true: Success.</description></item>
        /// <item><description>false: Failure.</description></item>
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

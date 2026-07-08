// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetDataSourceOrderConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataSourceOrderConfigResponseBodyData Data { get; set; }
        public class GetDataSourceOrderConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Maximum total document count</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalDocSize")]
            [Validation(Required=false)]
            public int? TotalDocSize { get; set; }

            /// <summary>
            /// <para>List of user-configured data source weights</para>
            /// </summary>
            [NameInMap("UserConfigDataSourceList")]
            [Validation(Required=false)]
            public List<GetDataSourceOrderConfigResponseBodyDataUserConfigDataSourceList> UserConfigDataSourceList { get; set; }
            public class GetDataSourceOrderConfigResponseBodyDataUserConfigDataSourceList : TeaModel {
                /// <summary>
                /// <para>Code description</para>
                /// 
                /// <b>Example:</b>
                /// <para>QuarkCommonNews</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Is enabled</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Display name</para>
                /// 
                /// <b>Example:</b>
                /// <para>夸克通用搜索</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Quantity</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <para>Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>SystemSearch</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error description</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>428DCC0D-3C63-5306-BD1B-124396AB97BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Is successful: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetOrgAndFactoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The code returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetOrgAndFactoryResponseBodyData> Data { get; set; }
        public class GetOrgAndFactoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1319617584664960</para>
            /// </summary>
            [NameInMap("aliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            /// <summary>
            /// <para>The sites.</para>
            /// </summary>
            [NameInMap("factoryList")]
            [Validation(Required=false)]
            public List<GetOrgAndFactoryResponseBodyDataFactoryList> FactoryList { get; set; }
            public class GetOrgAndFactoryResponseBodyDataFactoryList : TeaModel {
                /// <summary>
                /// <para>The site ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pn_95</para>
                /// </summary>
                [NameInMap("factoryId")]
                [Validation(Required=false)]
                public string FactoryId { get; set; }

                /// <summary>
                /// <para>The site name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ledi Industrial Park 1</para>
                /// </summary>
                [NameInMap("factoryName")]
                [Validation(Required=false)]
                public string FactoryName { get; set; }

            }

            /// <summary>
            /// <para>The enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6265f42XXXX2fec150</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <para>The enterprise name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ledi Industrial Park</para>
            /// </summary>
            [NameInMap("organizationName")]
            [Validation(Required=false)]
            public string OrganizationName { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

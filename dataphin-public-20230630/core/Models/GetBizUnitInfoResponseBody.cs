// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBizUnitInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data domain.</para>
        /// </summary>
        [NameInMap("BizUnitInfo")]
        [Validation(Required=false)]
        public GetBizUnitInfoResponseBodyBizUnitInfo BizUnitInfo { get; set; }
        public class GetBizUnitInfoResponseBodyBizUnitInfo : TeaModel {
            /// <summary>
            /// <para>The architects of the data domain.</para>
            /// </summary>
            [NameInMap("AccountList")]
            [Validation(Required=false)]
            public List<GetBizUnitInfoResponseBodyBizUnitInfoAccountList> AccountList { get; set; }
            public class GetBizUnitInfoResponseBodyBizUnitInfoAccountList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20001201</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The number of business objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizObjectCount")]
            [Validation(Required=false)]
            public int? BizObjectCount { get; set; }

            /// <summary>
            /// <para>The number of business activities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizProcessCount")]
            [Validation(Required=false)]
            public int? BizProcessCount { get; set; }

            /// <summary>
            /// <para>The business owners.</para>
            /// </summary>
            [NameInMap("BusinessLeaderList")]
            [Validation(Required=false)]
            public List<GetBizUnitInfoResponseBodyBizUnitInfoBusinessLeaderList> BusinessLeaderList { get; set; }
            public class GetBizUnitInfoResponseBodyBizUnitInfoBusinessLeaderList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20001201</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The number of subject domains.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataDomainCount")]
            [Validation(Required=false)]
            public int? DataDomainCount { get; set; }

            /// <summary>
            /// <para>The data owners.</para>
            /// </summary>
            [NameInMap("DataLeaderList")]
            [Validation(Required=false)]
            public List<GetBizUnitInfoResponseBodyBizUnitInfoDataLeaderList> DataLeaderList { get; set; }
            public class GetBizUnitInfoResponseBodyBizUnitInfoDataLeaderList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20001201</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The description of the business object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The English names of the data domain for the two environments: production and development.</para>
            /// </summary>
            [NameInMap("EnvList")]
            [Validation(Required=false)]
            public List<GetBizUnitInfoResponseBodyBizUnitInfoEnvList> EnvList { get; set; }
            public class GetBizUnitInfoResponseBodyBizUnitInfoEnvList : TeaModel {
                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试数据板块001_开发</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The environment identifier. Valid values: PROD and DEV.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("EnvName")]
                [Validation(Required=false)]
                public string EnvName { get; set; }

                /// <summary>
                /// <para>The English name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD_test001_dev</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-10 10:00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-10 10:00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The icon of the data domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icon-e-commerce</para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The data domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101001201</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modified the data domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30010010</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public string LastModifier { get; set; }

            /// <summary>
            /// <para>The name of the user who last modified the data domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("LastModifierName")]
            [Validation(Required=false)]
            public string LastModifierName { get; set; }

            /// <summary>
            /// <para>The production mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASIC: single-environment mode.</description></item>
            /// <item><description>DEV_PROD: development/production dual-environment mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEV_PROD</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the business object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>The owner of the business object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30010010</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

        }

        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

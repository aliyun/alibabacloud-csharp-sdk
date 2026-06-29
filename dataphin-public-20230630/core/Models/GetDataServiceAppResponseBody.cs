// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDataServiceAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the data service application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceAppResponseBodyData Data { get; set; }
        public class GetDataServiceAppResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认分组</para>
            /// </summary>
            [NameInMap("AppGroup")]
            [Validation(Required=false)]
            public string AppGroup { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The AppKey of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认应用</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认应用</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The AppSecret of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认应用</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>The IP whitelist addresses. Specify IP addresses or CIDR blocks separated by semicolons (;). CIDR blocks end with a slash (/) followed by a number in the range of 1 to 32. Example: 192.168.3.12/24.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IpWhitelist")]
            [Validation(Required=false)]
            public string IpWhitelist { get; set; }

            /// <summary>
            /// <para>Indicates whether the IP whitelist is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IpWhitelistStatus")]
            [Validation(Required=false)]
            public bool? IpWhitelistStatus { get; set; }

            /// <summary>
            /// <para>The list of owners.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<GetDataServiceAppResponseBodyDataOwnerList> OwnerList { get; set; }
            public class GetDataServiceAppResponseBodyDataOwnerList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The common scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>数据分析</para>
            /// </summary>
            [NameInMap("Scenarios")]
            [Validation(Required=false)]
            public string Scenarios { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateRumAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. 2XX indicates that the request was successful. 3XX indicates that the request was redirected. 4XX indicates that a request error occurred. 5XX indicates that a server error occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The application ID and domain names. This parameter is returned if the application is created. Multiple domain names are separated with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ggxxxnjuz@xxxx,xxxxxx-default-cn.rum.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateRumAppResponseBodyData Data { get; set; }
        public class CreateRumAppResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain name of the SDK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bxxxxxxx-sdk.rum.aliyuncs.com/v2/browser-sdk.js</para>
            /// </summary>
            [NameInMap("CdnDomain")]
            [Validation(Required=false)]
            public string CdnDomain { get; set; }

            /// <summary>
            /// <para>The endpoint that is used to report application data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxx-default-cn.rum.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The process ID (PID) of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>avccccxxxx@24cxxxxbf384dc6</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A474FF8-7861-4D00-81B5-5BC3DA4E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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

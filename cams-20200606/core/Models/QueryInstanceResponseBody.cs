// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>OK: The request is successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, refer to <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned when the call is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInstanceResponseBodyData Data { get; set; }
        public class QueryInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The channel type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIBER</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The contact email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:1@alibaba.com">1@alibaba.com</a></para>
            /// </summary>
            [NameInMap("ContactMail")]
            [Validation(Required=false)]
            public string ContactMail { get; set; }

            /// <summary>
            /// <para>The country code ID.</para>
            /// <remarks>
            /// <para>For detailed country codes, refer to <a href="https://help.aliyun.com/document_detail/608210.html">Country codes</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            /// <summary>
            /// <para>The customer type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("CustType")]
            [Validation(Required=false)]
            public string CustType { get; set; }

            /// <summary>
            /// <para>FacebookBmId</para>
            /// 
            /// <b>Example:</b>
            /// <para>39929****</para>
            /// </summary>
            [NameInMap("FacebookBmId")]
            [Validation(Required=false)]
            public string FacebookBmId { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ins</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>293939*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>viber_ins</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The name of the ISV/Client agreement file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alibaba.com/1.pdf">https://alibaba.com/1.pdf</a></para>
            /// </summary>
            [NameInMap("IsvTerms")]
            [Validation(Required=false)]
            public string IsvTerms { get; set; }

            /// <summary>
            /// <para>The enterprise address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("OfficeAddress")]
            [Validation(Required=false)]
            public string OfficeAddress { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The region to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The submission time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>140092992</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NULL</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29kskkd******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.</description></item>
        /// <item><description><b>false</b>: The call fails.</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneTwiceTelVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>PortabilityNumberNotSupported</b>: Queries for this ported number are not supported.</para>
        /// </description></item>
        /// <item><description><para><b>RequestNumberNotSupported</b>: Queries are not supported for numbers from China Broadnet (starting with 192), mobile virtual network operators, and other unsupported carriers.</para>
        /// </description></item>
        /// <item><description><para><b>RequestFrequencyLimit</b>: Carriers limit frequent queries for the same number. If you receive this error code, try again later.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>A charge applies when the value of <c>Code</c> is <c>OK</c> and the value of <c>VerifyResult</c> is not <c>0</c>. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html">Phone Number Service pricing</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A data structure that contains the verification results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneTwiceTelVerifyResponseBodyData Data { get; set; }
        public class DescribePhoneTwiceTelVerifyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The carrier that provides service for the number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CMCC</b>: China Mobile.</para>
            /// </description></item>
            /// <item><description><para><b>CUCC</b>: China Unicom.</para>
            /// </description></item>
            /// <item><description><para><b>CTCC</b>: China Telecom.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The carrier that currently provides service for the number. For a ported number, this is the destination carrier.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Cannot be determined.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The number is a recycled number.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: The number is not a recycled number.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: The number has been deactivated.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Unknown: The number was transferred to a new owner.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// <para>A description of the returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. This common parameter is returned with each request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68A40250-50CD-034C-B728-0BD135850177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

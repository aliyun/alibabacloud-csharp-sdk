// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id3MetaVerifyPROResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. <b>200</b> indicates that the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message of the API call.</para>
        /// <remarks>
        /// <para>Notice: This parameter only indicates whether the API call is abnormal.</para>
        /// </remarks>
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
        /// <para>2FA2C773-47DB-4156-B1EE-5B047321A939</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Id3MetaVerifyPROResponseBodyResultObject ResultObject { get; set; }
        public class Id3MetaVerifyPROResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The authoritative source verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Verification is consistent (billable).</description></item>
            /// <item><description><b>2</b>: Verification is inconsistent (billable).</description></item>
            /// <item><description><b>3</b>: No record found (not billable).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para><b>verifyScore</b>: The face comparison score. Value range: 0 to 1000. A higher score indicates a higher probability of the same face. A score &gt;= 700.0 confirms the same person.</para>
            /// </description></item>
            /// <item><description><para><b>faceAttack</b>: Returned when liveness detection is enabled (does not participate in the verification result decision).</para>
            /// </description></item>
            /// <item><description><para><b>invokeChannel</b>: The identifier of the actual invocation channel. 1: authoritative source. 0: comprehensive source.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;verifyScore&quot;: 810.28,
            /// &quot;faceAttack&quot;:&quot;N&quot;,
            /// &quot;invokeChannel&quot;: 1
            /// }</para>
            /// </summary>
            [NameInMap("FaceDetail")]
            [Validation(Required=false)]
            public string FaceDetail { get; set; }

            /// <summary>
            /// <para>Indicates whether the whitelist is hit: <b>Y</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("HitWhitelist")]
            [Validation(Required=false)]
            public string HitWhitelist { get; set; }

            /// <summary>
            /// <para>The authoritative source verification details. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>101</b>: Authentication passed.</para>
            /// </description></item>
            /// <item><description><para><b>201</b>: Authentication failed. The name does not match the ID card number.</para>
            /// </description></item>
            /// <item><description><para><b>202</b>: Authentication failed. Suspected to be the person.</para>
            /// </description></item>
            /// <item><description><para><b>203</b>: Authentication failed. No photo in the database.</para>
            /// </description></item>
            /// <item><description><para><b>204</b>: Authentication failed. Not the same person.</para>
            /// </description></item>
            /// <item><description><para><b>205</b>: Authentication failed. Modeling of the image to be compared failed.</para>
            /// </description></item>
            /// <item><description><para><b>206</b>: Authentication failed. The image format is incorrect.</para>
            /// </description></item>
            /// <item><description><para><b>207</b>: Authentication failed. The uploaded image is too small. Upload the image again.</para>
            /// </description></item>
            /// <item><description><para><b>208</b>: Authentication failed. The quality of the uploaded portrait photo is poor. Upload the photo again.</para>
            /// </description></item>
            /// <item><description><para><b>301</b>: No record found. The ID number does not exist in the database.</para>
            /// </description></item>
            /// <item><description><para><b>302</b>: No record found. Verification is not possible.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}

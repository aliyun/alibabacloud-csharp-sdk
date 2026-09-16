// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id3MetaVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. 200 indicates success. Other values indicate failure.</para>
        /// <para><b>Important</b></para>
        /// <list type="bullet">
        /// <item><description>This parameter indicates whether the API call is successful. For more information about return codes, see error codes.</description></item>
        /// <item><description>Check the business verification result in the fields of ResultObject.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <para><b>Important</b></para>
        /// <para>This parameter only indicates whether the API call is abnormal.</para>
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
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF03****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Id3MetaVerifyResponseBodyResultObject ResultObject { get; set; }
        public class Id3MetaVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The identity verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: verification is consistent.</description></item>
            /// <item><description>2: verification is inconsistent.</description></item>
            /// <item><description>3: no record found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The face comparison score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;verifyScore&quot;: 50.28594166529785
            /// }</para>
            /// </summary>
            [NameInMap("FaceDetail")]
            [Validation(Required=false)]
            public string FaceDetail { get; set; }

            /// <summary>
            /// <para>The authoritative source verification details. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>101: authentication passed.</para>
            /// </description></item>
            /// <item><description><para>201: authentication failed. The name does not match the ID card number.</para>
            /// </description></item>
            /// <item><description><para>202: authentication failed. The person is suspected to be the ID holder.</para>
            /// </description></item>
            /// <item><description><para>203: authentication failed. No photo exists in the database.</para>
            /// </description></item>
            /// <item><description><para>204: authentication failed. The person is not the same individual.</para>
            /// </description></item>
            /// <item><description><para>205: authentication failed. Modeling of the image to be compared failed.</para>
            /// </description></item>
            /// <item><description><para>206: authentication failed. The image format is incorrect.</para>
            /// </description></item>
            /// <item><description><para>207: authentication failed. The uploaded image is too small. Upload a new image.</para>
            /// </description></item>
            /// <item><description><para>208: authentication failed. The quality of the uploaded portrait photo is poor. Upload a new photo.</para>
            /// </description></item>
            /// <item><description><para>301: no record found. The ID number does not exist in the database.</para>
            /// </description></item>
            /// <item><description><para>302: no record found. Verification cannot be performed.</para>
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

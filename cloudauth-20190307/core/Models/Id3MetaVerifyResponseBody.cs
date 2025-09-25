// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id3MetaVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 indicates success, others indicate failure.
        /// <b>Important</b></para>
        /// <list type="bullet">
        /// <item><description>This parameter indicates whether the interface was called correctly. For detailed return code explanations, please refer to the error codes.</description></item>
        /// <item><description>Check the business verification result through the fields in <c>ResultObject</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Interface call return message.</para>
        /// <para><b>Important</b></para>
        /// <para>This parameter only indicates whether there was an exception with the interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF03****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Id3MetaVerifyResponseBodyResultObject ResultObject { get; set; }
        public class Id3MetaVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Identity verification result:</para>
            /// <list type="bullet">
            /// <item><description>1: Consistent</description></item>
            /// <item><description>2: Inconsistent</description></item>
            /// <item><description>3: No record found</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Image comparison score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;verifyScore&quot;: 50.28594166529785
            /// }</para>
            /// </summary>
            [NameInMap("FaceDetail")]
            [Validation(Required=false)]
            public string FaceDetail { get; set; }

        }

    }

}

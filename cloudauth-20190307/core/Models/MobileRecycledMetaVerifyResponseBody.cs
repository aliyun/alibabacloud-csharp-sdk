// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileRecycledMetaVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates success. Any other value indicates failure.</para>
        /// <remarks>
        /// <para><b>Important</b></para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter indicates whether the API operation is called correctly. For more information about return codes, see error codes.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FC3D6AC-9FED-4311-8DA7-C4BF47D9F260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public MobileRecycledMetaVerifyResponseBodyResultObject ResultObject { get; set; }
        public class MobileRecycledMetaVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The query result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: A query result is found.</description></item>
            /// <item><description>3: No query result is found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The carrier name. China Mobile: CMCC. China Unicom: CUCC. China Telecom: CTCC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>The detailed verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>101: The registration date is equal to or later than the phone number activation date.</description></item>
            /// <item><description>102: The registration date is earlier than the phone number activation date.</description></item>
            /// <item><description>103: The new subscriber has not been synchronized yet.</description></item>
            /// <item><description>301: Data exception or the subscriber has been deactivated.</description></item>
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

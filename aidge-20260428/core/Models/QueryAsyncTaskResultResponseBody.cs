// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class QueryAsyncTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The asynchronous task result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAsyncTaskResultResponseBodyData Data { get; set; }
        public class QueryAsyncTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;url\&quot;:\&quot;<a href="https://aidge-bailian-oss.oss-cn-beijing.aliyuncs.com/gaolinfeng/pdf_trans/translated_en.pdf?security-token=CAISzwJ1q6Ft5B2yfSjIr5ntKv7urOdn9YTeaVbb1lQRfcxi2Kz%2BgDz2IHhMeHFgAeAbs%2Fw%2Fm29W6v4SlqZdVplOWU3Da%2BB364xK7Q754wRDcULuv9I%2Bk5SANTW5KXyShb3%2FAYjQSNfaZY3eCTTtnTNyxr3XbCirW0ffX7SClZ9gaKZ8PGD6F00kYu1bPQx%2FssQXGGLMPPK2SH7Qj3HXEVBjt3gX6wo9y9zmk53FsUWA1QKmlr9F%2BdWhGPX%2BMZkwZqUYesyuwel7epDG1CNt8BVQ%2FM909vccoWuf7onNXgQJs0rZbbaMoscSJQ51aaV%2FFaUBt%2FXmi%2Fxzt6nJkID626jAvGbZzsW0rumBtyikcIvBXr5RHT3rIrVAU%2BuEf19557bo3dbfkNdWOrtHZDY5Qn9nURKxAbSEg2uBaWTIIJPmvc97r9wbhjuH87JeC0jQHt3xuRqAATp5EbLOeo%2BZktMLbi%2FUsZgcvdIEIv3tPBCYfyJnh%2Bj6U8IyaLKQYHQBtjsfyMngFfS09jFdjBcUebzvYJs21gyU5u%2FZ9SeReh%2FacuIMVoggWy3o9Y%2BnBA2QPCcKqVM7XlwriM%2FJOAyhvj%2Bjtj7BUoyD%2BrSgF5brq5ykjN7t2U7oIAA%3D&OSSAccessKeyId=STS.NZXaDZA8FBF5kpj2TDqCN7iUb&Expires=1780315869&Signature=CdbMkhcED4Ovhw438ZVe5nzU1mk%3D%5C%5C%22%7D">https://aidge-bailian-oss.oss-cn-beijing.aliyuncs.com/gaolinfeng/pdf_trans/translated_en.pdf?security-token=CAISzwJ1q6Ft5B2yfSjIr5ntKv7urOdn9YTeaVbb1lQRfcxi2Kz%2BgDz2IHhMeHFgAeAbs%2Fw%2Fm29W6v4SlqZdVplOWU3Da%2BB364xK7Q754wRDcULuv9I%2Bk5SANTW5KXyShb3%2FAYjQSNfaZY3eCTTtnTNyxr3XbCirW0ffX7SClZ9gaKZ8PGD6F00kYu1bPQx%2FssQXGGLMPPK2SH7Qj3HXEVBjt3gX6wo9y9zmk53FsUWA1QKmlr9F%2BdWhGPX%2BMZkwZqUYesyuwel7epDG1CNt8BVQ%2FM909vccoWuf7onNXgQJs0rZbbaMoscSJQ51aaV%2FFaUBt%2FXmi%2Fxzt6nJkID626jAvGbZzsW0rumBtyikcIvBXr5RHT3rIrVAU%2BuEf19557bo3dbfkNdWOrtHZDY5Qn9nURKxAbSEg2uBaWTIIJPmvc97r9wbhjuH87JeC0jQHt3xuRqAATp5EbLOeo%2BZktMLbi%2FUsZgcvdIEIv3tPBCYfyJnh%2Bj6U8IyaLKQYHQBtjsfyMngFfS09jFdjBcUebzvYJs21gyU5u%2FZ9SeReh%2FacuIMVoggWy3o9Y%2BnBA2QPCcKqVM7XlwriM%2FJOAyhvj%2Bjtj7BUoyD%2BrSgF5brq5ykjN7t2U7oIAA%3D&amp;OSSAccessKeyId=STS.NZXaDZA8FBF5kpj2TDqCN7iUb&amp;Expires=1780315869&amp;Signature=CdbMkhcED4Ovhw438ZVe5nzU1mk%3D\\&quot;}</a></para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The downstream task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-xxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The usage information.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAppSecretResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the application secret.</para>
        /// </summary>
        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public GetAppSecretResponseBodyAppSecret AppSecret { get; set; }
        public class GetAppSecretResponseBodyAppSecret : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>472457090344041****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the application secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2efd5004-005c-4f05-83c6-5b1dd176****</para>
            /// </summary>
            [NameInMap("AppSecretId")]
            [Validation(Required=false)]
            public string AppSecretId { get; set; }

            /// <summary>
            /// <para>The content of the application secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai78ZmmxnlUG1jXlBZRDFKos9DIjY4m17Q7dCpMwn1rqXsTGb1X1XmrmveMp****</para>
            /// </summary>
            [NameInMap("AppSecretValue")]
            [Validation(Required=false)]
            public string AppSecretValue { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-26T02:52:31Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE46FC3C-3BDE-4771-B531-27B7B6EB533D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListAppSecretIdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the application secret.</para>
        /// </summary>
        [NameInMap("AppSecrets")]
        [Validation(Required=false)]
        public ListAppSecretIdsResponseBodyAppSecrets AppSecrets { get; set; }
        public class ListAppSecretIdsResponseBodyAppSecrets : TeaModel {
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public List<ListAppSecretIdsResponseBodyAppSecretsAppSecret> AppSecret { get; set; }
            public class ListAppSecretIdsResponseBodyAppSecretsAppSecret : TeaModel {
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
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-26T03:18:39Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5F2FD500-7173-47D6-BD2F-EB60879B4F16</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

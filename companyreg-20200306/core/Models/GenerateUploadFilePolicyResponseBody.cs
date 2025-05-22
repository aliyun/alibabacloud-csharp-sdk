// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class GenerateUploadFilePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>OSSAccessKeyId</para>
        /// 
        /// <b>Example:</b>
        /// <para>hObpgEXoca42qH3V</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMjAyMS0xMi0wNlQwNjoxOTowMi40MjdaIiwiY29uZGl0aW9ucyI6W1siZXEiLCIkYnVja2V0IiwibXNlYS1jYWlzaHVpIl1dfQ==</para>
        /// </summary>
        [NameInMap("EncodedPolicy")]
        [Validation(Required=false)]
        public string EncodedPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1638169824405</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>company_apply_card/company_change_city/1577930895198750/1638170049657</para>
        /// </summary>
        [NameInMap("FileDir")]
        [Validation(Required=false)]
        public string FileDir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https://</para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>OSS Endpoint。</para>
        /// 
        /// <b>Example:</b>
        /// <para>//companyapply.oss-cn-zhangjiakou.aliyuncs.com/</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EB809CAB-82F7-5843-A42F-356770CD4914</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jykxhmskIF24sLlxc1GafU/eQMU=</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}

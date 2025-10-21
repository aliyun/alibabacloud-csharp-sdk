// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class CreateModelInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eas-m-12345678</para>
        /// </summary>
        [NameInMap("EasServiceId")]
        [Validation(Required=false)]
        public string EasServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("EasServiceName")]
        [Validation(Required=false)]
        public string EasServiceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("ModelCallName")]
        [Validation(Required=false)]
        public string ModelCallName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModelCategoryId")]
        [Validation(Required=false)]
        public long? ModelCategoryId { get; set; }

        /// <summary>
        /// <para>EAS Token</para>
        /// 
        /// <b>Example:</b>
        /// <para>MzJiMDI5MDliODc0MTlkYmI0ZDhlYmExYjczYTIyZTE3Zm********</para>
        /// </summary>
        [NameInMap("ModelToken")]
        [Validation(Required=false)]
        public string ModelToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://12345*****.cn-shanghai.aliyuncs.com/api/predict/demo">http://12345*****.cn-shanghai.aliyuncs.com/api/predict/demo</a></para>
        /// </summary>
        [NameInMap("ModelUrl")]
        [Validation(Required=false)]
        public string ModelUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://12345*****.vpc.cn-shanghai.aliyuncs.com/api/predict/demo">http://12345*****.vpc.cn-shanghai.aliyuncs.com/api/predict/demo</a></para>
        /// </summary>
        [NameInMap("ModelVpcUrl")]
        [Validation(Required=false)]
        public string ModelVpcUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>643168</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}

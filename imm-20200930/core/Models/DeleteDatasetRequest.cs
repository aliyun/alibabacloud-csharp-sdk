// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DeleteDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.<a href="https://help.aliyun.com/zh/imm/user-guide/create-datasets?spm=a2c4g.11186623.0.0.453e3cbf9vcZrq"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset001</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="https://help.aliyun.com/zh/imm/getting-started/create-a-project-1?spm=a2c4g.11186623.0.i30"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}

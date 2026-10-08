// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetFigureClusterRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset. For more information about how to obtain the dataset name, see <a href="~~CreateDataset~~">CreateDataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset001</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The object ID of the clustering group. You can obtain the object ID from the face group information returned by <a href="~~QueryFigureClusters~~">QueryFigureClusters</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-1f2e1a2c-d5ee-4bc5-84f6-fef94ea****</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, see <a href="~~CreateProject~~">CreateProject</a>.</para>
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

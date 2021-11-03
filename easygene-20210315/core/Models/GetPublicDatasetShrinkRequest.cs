// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetPublicDatasetShrinkRequest : TeaModel {
        /// <summary>
        /// 查询的字段名:DatasetNo, DatasetDescription, About, AccessRequirements, Copyright, Tags, UpdateFrequency, Locations, LastModified, RegionIds
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string AttributesShrink { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

    }

}

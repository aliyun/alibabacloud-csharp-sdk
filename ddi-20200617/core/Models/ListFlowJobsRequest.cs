// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowJobsRequest : TeaModel {
        /// <summary>
        /// 是否为临时查询。用于过滤作业。
        /// </summary>
        [NameInMap("Adhoc")]
        [Validation(Required=false)]
        public bool? Adhoc { get; set; }

        [NameInMap("ExactName")]
        [Validation(Required=false)]
        public string ExactName { get; set; }

        /// <summary>
        /// 作业ID。您可以调用ListFlowJob查看作业ID。
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 作业名称。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 当前页数。
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页的作业数量。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 项目ID。您可以调用ListFlowProject查看项目的ID。
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 地域ID。您可以调用DescribeRegions查看最新的阿里云地域列表。
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 作业类型。用于过滤作业，支持的类型有：SPARK，SPARK_STREAMING，ZEPPELIN。
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

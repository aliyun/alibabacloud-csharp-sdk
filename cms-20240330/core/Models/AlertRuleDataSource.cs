// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleDataSource : TeaModel {
        [NameInMap("dsList")]
        [Validation(Required=false)]
        public List<AlertRuleDataSourceDsList> DsList { get; set; }
        public class AlertRuleDataSourceDsList : TeaModel {
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("store")]
            [Validation(Required=false)]
            public string Store { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>实例id，当type=PROMETHEUS_DS/ENTERPRISE_DS时必填，为prometheus实例的clusterId或指标仓库名称</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>数据源类型</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

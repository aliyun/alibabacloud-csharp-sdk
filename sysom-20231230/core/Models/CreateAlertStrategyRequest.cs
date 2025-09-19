// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateAlertStrategyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strategy1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public CreateAlertStrategyRequestStrategy Strategy { get; set; }
        public class CreateAlertStrategyRequestStrategy : TeaModel {
            [NameInMap("clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<string> Items { get; set; }

        }

    }

}

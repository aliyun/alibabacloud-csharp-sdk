// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class AddMetaDataComponentRequest : TeaModel {
        /// <summary>
        /// <para>The data source category. Valid values: DATASET, WORKFLOW, ENGINE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKFLOW</para>
        /// </summary>
        [NameInMap("categoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>The role of the data source in the migration pipeline. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: source.</description></item>
        /// <item><description>1: destination.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("componentType")]
        [Validation(Required=false)]
        public int? ComponentType { get; set; }

        /// <summary>
        /// <para>The datasource config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;endpoint&quot;:&quot;...&quot;,&quot;token&quot;:&quot;******&quot;}</para>
        /// </summary>
        [NameInMap("dsConfig")]
        [Validation(Required=false)]
        public string DsConfig { get; set; }

        /// <summary>
        /// <para>The description of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data source description</para>
        /// </summary>
        [NameInMap("dsDesc")]
        [Validation(Required=false)]
        public string DsDesc { get; set; }

        /// <summary>
        /// <para>The external ID of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>290</para>
        /// </summary>
        [NameInMap("dsId")]
        [Validation(Required=false)]
        public string DsId { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_ds318_hangzhou_0428</para>
        /// </summary>
        [NameInMap("dsName")]
        [Validation(Required=false)]
        public string DsName { get; set; }

        /// <summary>
        /// <para>The connectivity status of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dsStatus")]
        [Validation(Required=false)]
        public int? DsStatus { get; set; }

        /// <summary>
        /// <para>The type of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hive</para>
        /// </summary>
        [NameInMap("dsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// <para>The version of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.2.0</para>
        /// </summary>
        [NameInMap("dsVersion")]
        [Validation(Required=false)]
        public string DsVersion { get; set; }

    }

}

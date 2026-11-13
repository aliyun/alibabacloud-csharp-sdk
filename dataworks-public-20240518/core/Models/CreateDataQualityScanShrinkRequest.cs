// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityScanShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a-customized-uuid</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The compute engine used when the data quality monitor runs. This parameter is optional. If it is not specified, the data source connection specified in the Spec is used.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResourceShrink { get; set; }

        /// <summary>
        /// <para>The description of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily data quality scanning of ods tables.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configuration for hooks that run after the data quality monitor finishes.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string HooksShrink { get; set; }

        /// <summary>
        /// <para>The name of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_quality_scan_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The user ID of the owner of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The execution parameter definitions of the data quality monitor.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://dataworks.console.aliyun.com/overview">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID. This parameter specifies the DataWorks workspace for the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group used when the data quality monitor runs.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResourceShrink { get; set; }

        /// <summary>
        /// <para>The Spec code that defines the data quality monitor. For more information, see <a href="https://help.aliyun.com/document_detail/2963394.html">Data quality spec configuration guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;datasets&quot;: [
        ///         {
        ///             &quot;type&quot;: &quot;Table&quot;,
        ///             &quot;dataSource&quot;: {
        ///                 &quot;name&quot;: &quot;odps_first&quot;,
        ///                 &quot;envType&quot;: &quot;Prod&quot;
        ///             },
        ///             &quot;tables&quot;: [
        ///                 &quot;ods_d_user_info&quot;
        ///             ],
        ///             &quot;filter&quot;: &quot;pt = $[yyyymmdd-1]&quot;
        ///         }
        ///     ],
        ///     &quot;rules&quot;: [
        ///         {
        ///             &quot;assertion&quot;: &quot;row_count &gt; 0&quot;
        ///         }, {
        ///             &quot;templateId&quot;: &quot;SYSTEM:field:null_value:fixed&quot;,
        ///             &quot;pass&quot;: &quot;when = 0&quot;,
        ///             &quot;name&quot;: &quot;The id cannot be empty.&quot;,
        ///             &quot;severity&quot;: &quot;High&quot;,
        ///              &quot;identity&quot;: &quot;a-customized-data-quality-rule-uuid&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The trigger settings of the data quality monitor.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}

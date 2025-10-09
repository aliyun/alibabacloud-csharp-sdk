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
        /// <para>The compute engine used at runtime. If not specified, the data source defined in the Spec is used.</para>
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
        /// <para>The Hook configurations after the data quality monitoring run ends.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string HooksShrink { get; set; }

        /// <summary>
        /// <para>The data quality monitoring name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_quality_scan_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the user who owns of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The definition of execution parameters for the data quality monitoring.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console and go to the workspace configuration page to obtain the workspace ID. This parameter is required to specify the target DataWorks workspace for this API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group used during execution of the data quality monitoring.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResourceShrink { get; set; }

        /// <summary>
        /// <para>Spec code for the content of the data quality monitoring.</para>
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
        /// <para>The trigger configurations of the data quality monitoring task.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}

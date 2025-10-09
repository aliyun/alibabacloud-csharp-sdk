// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityScanShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The compute engine used during execution. If it\&quot;s not specified, the data source connection defined in the Spec will be used.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResourceShrink { get; set; }

        /// <summary>
        /// <para>Description of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily data quality scanning of ods tables.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The hook configuration after the data quality monitor stops.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string HooksShrink { get; set; }

        /// <summary>
        /// <para>The ID of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>231263586109857423</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The definition of execution parameters for the data quality monitor.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace where the data quality monitor resides. You can obtain the workspace ID by calling the <a href="https://help.aliyun.com/document_detail/2852607.html">ListProjects</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group used during the execution of the data quality monitor.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResourceShrink { get; set; }

        /// <summary>
        /// <para>The Spec code of the data quality monitoring content. For more information, see <a href="https://help.aliyun.com/document_detail/2963394.html">Data quality Spec configuration description</a>.</para>
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
        /// <para>Trigger settings for the data quality monitor.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}

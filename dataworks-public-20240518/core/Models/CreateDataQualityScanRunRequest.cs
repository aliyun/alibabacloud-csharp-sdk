// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityScanRunRequest : TeaModel {
        /// <summary>
        /// <para>The data quality scan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20000001</para>
        /// </summary>
        [NameInMap("DataQualityScanId")]
        [Validation(Required=false)]
        public long? DataQualityScanId { get; set; }

        /// <summary>
        /// <para>The parameters for the run. The <c>triggerTime</c> parameter is required.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateDataQualityScanRunRequestParameters> Parameters { get; set; }
        public class CreateDataQualityScanRunRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter. The only supported value is:</para>
            /// <list type="bullet">
            /// <item><description>triggerTime</description></item>
            /// </list>
            /// <para>No other scheduling parameters are currently supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>triggerTime</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// <list type="bullet">
            /// <item><description>If the parameter name is triggerTime, this value must be the trigger time as a timestamp.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1775812636</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Specifies the scheduling resource group used to run the data quality scan. This object uses the same data structure as the scheduling API.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public CreateDataQualityScanRunRequestRuntimeResource RuntimeResource { get; set; }
        public class CreateDataQualityScanRunRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <para>The number of compute units (CUs) to reserve from the resource group for the data quality scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public float? Cu { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e9455a13-ff00-4965-833c-337546ba4854</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The image configuration for running the data quality scan on the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxxxx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

        }

    }

}

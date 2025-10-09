// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityScanRunRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20000001</para>
        /// </summary>
        [NameInMap("DataQualityScanId")]
        [Validation(Required=false)]
        public long? DataQualityScanId { get; set; }

        /// <summary>
        /// <para>The parameter settings used during the actual run. The <c>triggerTime</c> parameter is required.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateDataQualityScanRunRequestParameters> Parameters { get; set; }
        public class CreateDataQualityScanRunRequestParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>regiondt</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter value. You can use a scheduling time expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai$[yyyy-mm-dd-1]</para>
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
        /// <para>The scheduling resource group used when running the data quality monitor. This resource group uses the same data structure as in the scheduling API.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public CreateDataQualityScanRunRequestRuntimeResource RuntimeResource { get; set; }
        public class CreateDataQualityScanRunRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <para>The Compute Resources (CUs) reserved for running the data quality monitor in the resource group.</para>
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
            /// <para>The image settings used when running the data quality monitor in the resource group.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityScanRunShrinkRequest : TeaModel {
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
        public string ParametersShrink { get; set; }

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
        public string RuntimeResourceShrink { get; set; }

    }

}

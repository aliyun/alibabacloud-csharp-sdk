// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DataImageRegionDistributeMapValue : TeaModel {
        /// <summary>
        /// <para>The status of the image distribution task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AVAILABLE: The task is ready.</description></item>
        /// <item><description>DELETE: The task is deleted.</description></item>
        /// <item><description>INIT: The task is being initialized.</description></item>
        /// <item><description>CREATE_FAILED: The task failed to be created.</description></item>
        /// <item><description>CREATING: The task is being created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("DistributeStatus")]
        [Validation(Required=false)]
        public string DistributeStatus { get; set; }

        /// <summary>
        /// <para>The distribution progress of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100%</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

    }

}

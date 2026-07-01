// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAvatarTrainingJobsRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The page number.</para>
        /// </description></item>
        /// <item><description><para>Default value: 1.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The number of entries per page.</para>
        /// </description></item>
        /// <item><description><para>Default value: 10.</para>
        /// </description></item>
        /// <item><description><para>Valid values: 1 to 100.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The job state.</para>
        /// </description></item>
        /// <item><description><para>Valid values: Init, Queuing, Training, Success, and Fail.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

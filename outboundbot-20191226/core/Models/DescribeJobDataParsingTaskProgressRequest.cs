// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobDataParsingTaskProgressRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c209abb3-6804-4a75-b2c7-dd55c8c61b6a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50d5e164-9365-4261-980e-3d979c2c948c</para>
        /// </summary>
        [NameInMap("JobDataParsingTaskId")]
        [Validation(Required=false)]
        public string JobDataParsingTaskId { get; set; }

    }

}

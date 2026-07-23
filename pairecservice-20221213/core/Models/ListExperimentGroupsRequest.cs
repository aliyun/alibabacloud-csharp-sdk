// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListExperimentGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can get this ID by calling the ListInstances operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-abcdefg1234</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The layer ID. You can get this ID by calling the ListLayers operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LayerId")]
        [Validation(Required=false)]
        public string LayerId { get; set; }

        /// <summary>
        /// <para>The status of the experiment group. Valid values: Offline, Online, and Pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The end time for filtering experiment groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-31 12:00:00</para>
        /// </summary>
        [NameInMap("TimeRangeEnd")]
        [Validation(Required=false)]
        public string TimeRangeEnd { get; set; }

        /// <summary>
        /// <para>The start time for filtering experiment groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-30 12:00:00</para>
        /// </summary>
        [NameInMap("TimeRangeStart")]
        [Validation(Required=false)]
        public string TimeRangeStart { get; set; }

    }

}

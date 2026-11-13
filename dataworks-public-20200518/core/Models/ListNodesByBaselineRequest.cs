// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesByBaselineRequest : TeaModel {
        /// <summary>
        /// <para>The baseline ID. To obtain the baseline ID, call ListProjects to obtain the project ID, and then call ListBaselineConfigs by using the project ID to obtain the baseline ID from the response. If no baseline exists in the current workspace, create one in the DataWorks console first.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

    }

}

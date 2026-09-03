// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeFeatureTrialInfoRequest : TeaModel {
        /// <summary>
        /// <para>The feature type. Currently, only the free trial information of Tablestore backup can be queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OTS_BACKUP</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public string FeatureType { get; set; }

    }

}

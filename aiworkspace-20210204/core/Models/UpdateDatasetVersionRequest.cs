// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateDatasetVersionRequest : TeaModel {
        /// <summary>
        /// <para>The number of dataset files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        /// <summary>
        /// <para>The size of the space occupied by dataset files. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>DatasetTaskRamRole</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890123456:role/role-name</para>
        /// </summary>
        [NameInMap("DatasetTaskRamRole")]
        [Validation(Required=false)]
        public string DatasetTaskRamRole { get; set; }

        /// <summary>
        /// <para>The custom description of the dataset, which is used to distinguish different datasets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of a dataset version.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The extended field in JsonString format. When DLC uses the dataset, you can specify the default mount path of the dataset by configuring the mountPath field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;mountPath&quot;: &quot;/mnt/data/&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("UserMetricsEndpoints")]
        [Validation(Required=false)]
        public List<UserMetricsEndpoint> UserMetricsEndpoints { get; set; }

    }

}

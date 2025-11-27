// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class BatchIndexFileMetaShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.<a href="~~478160~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The objects in Object Storage Service (OSS). Specify OSS objects by using a JSON array. You can specify up to 100 objects in an array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public string FilesShrink { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The user-defined data that you want to return in asynchronous messages. This parameter takes effect only when you specify the MNS settings in the Notification parameter. The maximum information length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;id&quot;: &quot;test-id&quot;,
        ///       &quot;name&quot;: &quot;test-name&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

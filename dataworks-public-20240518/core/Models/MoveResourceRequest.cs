// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class MoveResourceRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the data development file resource.</para>
        /// <remarks>
        /// <para>Notice: Before SDK version 8.0.0, this field is of the Long type. In SDK version 8.0.0 and later, this field is of the String type. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>652567824470354XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The destination path for the move operation. Do not include the file resource name in the path.</para>
        /// <para>For example, to change the path of the math.py file to root/demo/math.py, set this parameter to root/demo.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root/demo</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for this API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class MoveResourceRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the Data Studio file resource.</para>
        /// <remarks>
        /// <para> This field is of the Long type in SDK versions prior to 8.0.0, and of the String type in SDK versions 8.0.0 and later. This change does not affect normal SDK usage; the parameter will still be returned according to the type defined in the SDK. However, compilation failures may occur due to the type change only when upgrading the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
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
        /// <para>The unique identifier of the Data Studio file resource.</para>
        /// <remarks>
        /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. However, compilation failures may occur due to the type change only when upgrading the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root/demo</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the ID.</para>
        /// <para>You can use this parameter to specify the DataWorks workspace on which you want to perform the API operation.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectIdsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the desired Alibaba Cloud account.</para>
        /// <para>You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks</a> console and move the pointer over the profile picture in the upper-right corner to view the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>171111</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateSubCrowdRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can obtain the instance ID by calling the ListInstances API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The source of users for the sub-crowd. Valid values: ● ManualInput: manual input ● UploadFile: file upload</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManualInput</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>A comma-separated list of users in the sub-crowd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1,user2,user3</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public string Users { get; set; }

    }

}

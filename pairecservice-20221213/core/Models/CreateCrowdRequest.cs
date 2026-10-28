// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateCrowdRequest : TeaModel {
        /// <summary>
        /// <para>The description of the crowd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the ListInstances operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-abcdefg1234</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The label of the crowd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os=android</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The name of the crowd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleCrowd</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source of the crowd. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ManualInput: Manual input.</description></item>
        /// <item><description>UploadFile: File upload.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ManualInput</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The users included in the crowd. Separate multiple users with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1,user2,user3</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public string Users { get; set; }

    }

}

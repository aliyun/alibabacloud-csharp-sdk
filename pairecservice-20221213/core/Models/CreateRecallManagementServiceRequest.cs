// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateRecallManagementServiceRequest : TeaModel {
        /// <summary>
        /// <para><b>The description for the recall management service.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test recall</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para><b>The instance ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para><b>The name of the recall management service.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>hot_global_recall</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}

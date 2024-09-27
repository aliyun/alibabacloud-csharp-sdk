// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ModifyApplicationSpecRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02S7UU41WKJL7ERR</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public List<ModifyApplicationSpecRequestInstanceSpec> InstanceSpec { get; set; }
        public class ModifyApplicationSpecRequestInstanceSpec : TeaModel {
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public Dictionary<string, object> Configuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rm-2ze8f4ah378a*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}

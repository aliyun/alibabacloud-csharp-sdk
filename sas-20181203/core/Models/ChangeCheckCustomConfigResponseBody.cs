// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckCustomConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the invalid custom configuration items of the check item.</para>
        /// </summary>
        [NameInMap("IllegalCustomConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigResponseBodyIllegalCustomConfigs> IllegalCustomConfigs { get; set; }
        public class ChangeCheckCustomConfigResponseBodyIllegalCustomConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the custom configuration item, which is unique in a check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SessionTimeMax</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>An array that consists of the invalid parameters required for fixing risk items.</para>
        /// </summary>
        [NameInMap("IllegalRepairConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigResponseBodyIllegalRepairConfigs> IllegalRepairConfigs { get; set; }
        public class ChangeCheckCustomConfigResponseBodyIllegalRepairConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the invalid parameter required for fixing a risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SessionTimeMax</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DA8133CC-CCA0-5CF2-BF64-FE7D52C44***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

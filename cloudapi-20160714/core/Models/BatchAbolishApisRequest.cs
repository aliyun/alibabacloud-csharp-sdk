// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class BatchAbolishApisRequest : TeaModel {
        /// <summary>
        /// <para>The APIs that you want to operate.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Api")]
        [Validation(Required=false)]
        public List<BatchAbolishApisRequestApi> Api { get; set; }
        public class BatchAbolishApisRequestApi : TeaModel {
            /// <summary>
            /// <para>The ID of the API.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>994f72dcdaf04af0b38022c65fdbd1ac</para>
            /// </summary>
            [NameInMap("ApiUid")]
            [Validation(Required=false)]
            public string ApiUid { get; set; }

            /// <summary>
            /// <para>The ID of the API group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ced5ab777f7b440398ea70e4470124de</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The ID of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>979fd16250644d5b82173534f465ac77</para>
            /// </summary>
            [NameInMap("StageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// <para>The name of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RELEASE</para>
            /// </summary>
            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

        }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

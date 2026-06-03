// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class CopyVerifySchemeRequest : TeaModel {
        /// <summary>
        /// <para>native：1，web：5</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CmApiCode")]
        [Validation(Required=false)]
        public long? CmApiCode { get; set; }

        /// <summary>
        /// <para>true，将在移动侧创建新的AppId，false将直接从模版方案中复制已经创建的移动AppId信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CmNewFlag")]
        [Validation(Required=false)]
        public bool? CmNewFlag { get; set; }

        /// <summary>
        /// <para>native：3，web：8</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CtApiCode")]
        [Validation(Required=false)]
        public long? CtApiCode { get; set; }

        /// <summary>
        /// <para>true，将在电信侧创建新的AppId，false将直接从模版方案中复制已经创建的电信AppId信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CtNewFlag")]
        [Validation(Required=false)]
        public bool? CtNewFlag { get; set; }

        /// <summary>
        /// <para>native：9，web：10</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("CuApiCode")]
        [Validation(Required=false)]
        public long? CuApiCode { get; set; }

        /// <summary>
        /// <para>true，将在联通侧创建新的AppId，false将直接从模版方案中复制已经创建的联通AppId信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CuNewFlag")]
        [Validation(Required=false)]
        public bool? CuNewFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>****@xxx.com</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC1001212***32</para>
        /// </summary>
        [NameInMap("ModelSceneCode")]
        [Validation(Required=false)]
        public string ModelSceneCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

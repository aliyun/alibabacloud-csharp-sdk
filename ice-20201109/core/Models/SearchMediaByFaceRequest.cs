// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByFaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2d3bf1e35a1e42b5ab338d701efa****</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zxtest-huangxuan-2023-3-7-V1</para>
        /// </summary>
        [NameInMap("FaceSearchToken")]
        [Validation(Required=false)]
        public string FaceSearchToken { get; set; }

        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.oss-cn-shanghai.aliyuncs.com/input/huangxuan</b></b>.jpg</para>
        /// </summary>
        [NameInMap("PersonImageUrl")]
        [Validation(Required=false)]
        public string PersonImageUrl { get; set; }

        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}

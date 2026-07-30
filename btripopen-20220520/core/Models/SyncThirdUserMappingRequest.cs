// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class SyncThirdUserMappingRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the mapping is valid.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The target mapping system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weCom</para>
        /// </summary>
        [NameInMap("third_channel_type")]
        [Validation(Required=false)]
        public string ThirdChannelType { get; set; }

        /// <summary>
        /// <para>The user ID in the target mapping system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>third_user_2234</para>
        /// </summary>
        [NameInMap("third_user_id")]
        [Validation(Required=false)]
        public string ThirdUserId { get; set; }

        /// <summary>
        /// <para>The Alibaba Business Travel user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

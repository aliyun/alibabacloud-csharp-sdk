// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The root path of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("BasePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The description of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New weather informations.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the API group. This ID is generated by the system and globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>523e8dc7bbe04613b5b1d726c2a7889d</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the group to which an API belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewWeather</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CF287C6-CE5B-477B-BE27-C48F99EADBC8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The second-level domain name automatically assigned to the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>523e8dc7bbe04613b5b1d726c2a7889d-cn-hangzhou.alicloudapi.com</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

    }

}

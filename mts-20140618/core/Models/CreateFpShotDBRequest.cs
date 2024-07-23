// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class CreateFpShotDBRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the media fingerprint library. By default, this parameter is left empty. You can customize the configurations based on your business requirements. The value must be a string in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The description of the media fingerprint library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The library is a text fingerprint library.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The model ID of the media fingerprint library. To create a text fingerprint library, set the parameter to <b>11</b>. To create a video fingerprint library, set the parameter to <b>12</b>. To create an audio fingerprint library, set the parameter to <b>13</b>. To create an image fingerprint library, set the parameter to <b>14</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public int? ModelId { get; set; }

        /// <summary>
        /// <para>The name of the media fingerprint library.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

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

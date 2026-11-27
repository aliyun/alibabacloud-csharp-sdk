// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLJobDataSourceConfig : TeaModel {
        /// <summary>
        /// <para>The AI computing CPFS access point ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-example</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>The datasource ID. You must specify one of DataSourceId, Uri, or ModelId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-gx8xxxxx</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The datasource version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DataSourceVersion")]
        [Validation(Required=false)]
        public string DataSourceVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable data caching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCache")]
        [Validation(Required=false)]
        public bool? EnableCache { get; set; }

        /// <summary>
        /// <para>The ModelGallery model ID to mount. The latest version of the model that you have access to is used. You must specify one of DataSourceId, Uri, or ModelId. Model mounting supports read-only access only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-v63llpfh7u824imbni</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The mount access mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RO</para>
        /// </summary>
        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>The absolute mount path in the worker container. This parameter is required for RLJob datasources.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/input</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// <para>The extended datasource configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role used to access the datasource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1872xxxxxxxxx:role/account-pai-prod</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The JSON string of the role chain used to access the datasource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("RoleChain")]
        [Validation(Required=false)]
        public string RoleChain { get; set; }

        /// <summary>
        /// <para>The datasource URI. You must specify one of DataSourceId, Uri, or ModelId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://example-bucket/data/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}

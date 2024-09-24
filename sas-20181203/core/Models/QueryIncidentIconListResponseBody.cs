// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentIconListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: The request was successful.</description></item>
        /// <item><description><b>400</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The information about the entities and edges.</para>
        /// </summary>
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public QueryIncidentIconListResponseBodyInfoList InfoList { get; set; }
        public class QueryIncidentIconListResponseBodyInfoList : TeaModel {
            /// <summary>
            /// <para>The information about the entities.</para>
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentIconListResponseBodyInfoListEntityTypeList> EntityTypeList { get; set; }
            public class QueryIncidentIconListResponseBodyInfoListEntityTypeList : TeaModel {
                /// <summary>
                /// <para>The display color of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#fff</para>
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// <para>The icon that corresponds to the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN011BZBvK1oifgsWIXoO_!!60000*****-55-tps-32-32.svg">https://img.alicdn.com/imgextra/i4/O1CN011BZBvK1oifgsWIXoO_!!60000*****-55-tps-32-32.svg</a></para>
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// <para>The display sequence of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public string DisplayOrder { get; set; }

                /// <summary>
                /// <para>The display template of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;name&quot;:&quot;${sas.trace2.name.logtime}&quot;,&quot;value&quot;:&quot;$!{time}&quot;},{&quot;name&quot;:&quot;${sas.trace2.name.node_type}&quot;,&quot;value&quot;:&quot;${sas.trace2.name.ip}&quot;},{&quot;name&quot;:&quot;${sas.trace2.property.name}&quot;,&quot;value&quot;:&quot;$!{name}&quot;}#if($p_log_time),{&quot;name&quot;:&quot;${sas.trace2.property.log_time}&quot;,&quot;value&quot;:&quot;$!{p_log_time}&quot;}#end#if($p_pid),{&quot;name&quot;:&quot;${sas.trace2.property.pid}&quot;,&quot;value&quot;:&quot;$!{p_pid}&quot;}#end#if($p_procname),{&quot;name&quot;:&quot;${sas.trace2.property.procname}&quot;,&quot;value&quot;:&quot;$!{p_procname}&quot;}#end#if($p_proc_path),{&quot;name&quot;:&quot;${sas.trace2.property.proc_path}&quot;,&quot;value&quot;:&quot;$!{p_proc_path}&quot;}#end#if($p_cmdline),{&quot;name&quot;:&quot;${sas.trace2.property.cmdline}&quot;,&quot;value&quot;:&quot;$!{p_cmdline}&quot;}#end#if($p_username),{&quot;name&quot;:&quot;${sas.trace2.property.username}&quot;,&quot;value&quot;:&quot;$!{p_username}&quot;}#end#if($p_cwd),{&quot;name&quot;:&quot;${sas.trace2.property.cwd}&quot;,&quot;value&quot;:&quot;$!{p_cwd}&quot;}#end#if($p_filepath),{&quot;name&quot;:&quot;${sas.trace2.property.filepath}&quot;,&quot;value&quot;:&quot;$!{p_filepath}&quot;}#end#if($p_md5),{&quot;name&quot;:&quot;${sas.trace2.property.md5}&quot;,&quot;value&quot;:&quot;$!{p_md5}&quot;}#end#if($p_ctime),{&quot;name&quot;:&quot;${sas.trace2.property.ctime}&quot;,&quot;value&quot;:&quot;$!{p_ctime}&quot;}#end#if($p_mtime),{&quot;name&quot;:&quot;${sas.trace2.property.mtime}&quot;,&quot;value&quot;:&quot;$!{p_mtime}&quot;}#end#if($p_size),{&quot;name&quot;:&quot;${sas.trace2.property.size}&quot;,&quot;value&quot;:&quot;$!{p_size}&quot;}#end#if($p_port),{&quot;name&quot;:&quot;${sas.trace2.property.port}&quot;,&quot;value&quot;:&quot;$!{p_port}&quot;}#end#if($p_ip),{&quot;name&quot;:&quot;${sas.trace2.property.ip}&quot;,&quot;value&quot;:&quot;$!{p_ip}&quot;}#end#if($p_src_ip),{&quot;name&quot;:&quot;${sas.trace2.property.src_ip}&quot;,&quot;value&quot;:&quot;$!{p_src_ip}&quot;}#end#if($p_dst_ip),{&quot;name&quot;:&quot;${sas.trace2.property.dst_ip}&quot;,&quot;value&quot;:&quot;$!{p_dst_ip}&quot;}#end#if($p_host),{&quot;name&quot;:&quot;${sas.trace2.property.host}&quot;,&quot;value&quot;:&quot;$!{p_host}&quot;}#end#if($p_uri),{&quot;name&quot;:&quot;${sas.trace2.property.uri}&quot;,&quot;value&quot;:&quot;$!{p_uri}&quot;}#end#if($p_post_data),{&quot;name&quot;:&quot;${sas.trace2.property.post_data}&quot;,&quot;value&quot;:&quot;$!{p_post_data}&quot;}#end#if($p_content),{&quot;name&quot;:&quot;${sas.trace2.property.content}&quot;,&quot;value&quot;:&quot;$!{p_content}&quot;}#end#if($p_type),{&quot;name&quot;:&quot;${sas.trace2.property.type}&quot;,&quot;value&quot;:&quot;$!{p_type}&quot;}#end]&quot;,</para>
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// <para>The time when the entity was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-08T15:27Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the entity was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-11T10:16Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8038****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the entity is a virtual node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsVirtualNode")]
                [Validation(Required=false)]
                public string IsVirtualNode { get; set; }

                /// <summary>
                /// <para>The name of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>shujuku</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kube-system</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The tag that indicates whether tracing was successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TraceSuccessFlag")]
                [Validation(Required=false)]
                public string TraceSuccessFlag { get; set; }

            }

            /// <summary>
            /// <para>The information about the edges.</para>
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentIconListResponseBodyInfoListRelationTypeList> RelationTypeList { get; set; }
            public class QueryIncidentIconListResponseBodyInfoListRelationTypeList : TeaModel {
                /// <summary>
                /// <para>The direction of the edge. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: forward</description></item>
                /// <item><description><b>0</b>: reverse</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public string Directed { get; set; }

                /// <summary>
                /// <para>The display color of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FFF</para>
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// <para>The icon that corresponds to the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01ft6rvQ22uUX2JsTmv_!!600000******-55-tps-12-12.svg">https://img.alicdn.com/imgextra/i4/O1CN01ft6rvQ22uUX2JsTmv_!!600000******-55-tps-12-12.svg</a></para>
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// <para>The display template of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_template</para>
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// <para>The time when the edge was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>167660031*****</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the edge was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-04T17:35Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4556****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>policy-auto-effs3b</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lkl-zf-bs-lams</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The display type of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The consumed time of the request. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyNoticeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The notification configuration type. By default, notifications are sent by SMS, email, or internal message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cms</b>: CloudMonitor push.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cms</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The focus level. Separate multiple levels with commas (,).</para>
        /// <para>When <b>Project</b> is <b>yundun_soar_incident_generate</b> or <b>yundun_soar_incident_update</b>, valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CRITICAL</b>: Critical.</description></item>
        /// <item><description><b>HIGH</b>: High-risk.</description></item>
        /// <item><description><b>MEDIUM</b>: Medium-risk.</description></item>
        /// <item><description><b>LOW</b>: Low-risk.</description></item>
        /// <item><description><b>INFO</b>: Informational.</description></item>
        /// </list>
        /// <para>When <b>Project</b> is <b>yundun_sas_antiransomware_task</b>, valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b>: Execution succeeded.</description></item>
        /// <item><description><b>Failed</b>: Execution failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CRITICAL,HIGH</para>
        /// </summary>
        [NameInMap("FocusLevel")]
        [Validation(Required=false)]
        public string FocusLevel { get; set; }

        /// <summary>
        /// <h3>Project identity</h3>
        /// <h4>When the BizType field is empty: valid values</h4>
        /// <list type="bullet">
        /// <item><description><b>yundun_security_Weekreport</b>: Security weekly report (email only)</description></item>
        /// <item><description><b>sas_healthcheck</b>: Baseline check</description></item>
        /// <item><description><b>yundun_defennce_antiRansomware_overflow</b>: Anti-ransomware storage space exceeded</description></item>
        /// <item><description><b>yundun_sas_cloudsiem_log</b>: Cloud Threat Detection and Response (CTDR) log excess notification</description></item>
        /// <item><description><b>sas_suspicious</b>: Security alert</description></item>
        /// <item><description><b>yundun_aegis_AV_true</b>: Precise defense</description></item>
        /// <item><description><b>yundun_sas_ak_leakage AccessKey</b>: AccessKey leak intelligence</description></item>
        /// <item><description><b>yundun_sas_config_alert</b>: Cloud platform configuration check</description></item>
        /// <item><description><b>yundun_sas_vul_Emergency</b>: Emergency vulnerability intelligence</description></item>
        /// <item><description><b>yundun_webguard_event</b>: Web tamper-proofing</description></item>
        /// <item><description><b>yundun_sas_cloud_native_firewall</b>: Container firewall anomaly alert notification (email only)</description></item>
        /// <item><description><b>yundun_sas_cloud_native_firewall_Defense</b>: Container firewall active defense notification (email only)</description></item>
        /// <item><description><b>yundun_IP_Blocking</b>: Malicious IP blocking alerting notification</description></item>
        /// <item><description><b>yundun_sas_anti_virus_config</b>: Virus scan notification</description></item>
        /// <item><description><b>yundun_sas_log</b>: Log storage exceeded</description></item>
        /// <item><description><b>yundun_honeypot_alarm</b>: Cloud honeypot alerting</description></item>
        /// <item><description><b>aliyun_rasp_alarm</b>: Application protection alerting</description></item>
        /// <item><description><b>yundun_soar_incident_generate</b>: New security incident</description></item>
        /// <item><description><b>yundun_soar_incident_update</b>: Updated security incident<remarks>
        /// <para><b>yundun_security_Weekreport</b> sends a weekly report to notify you of unresolved vulnerabilities.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <hr>
        /// <h4>When the BizType field is <c>cms</c>: valid values</h4>
        /// <list type="bullet">
        /// <item><description><b>Vul_event</b>: Vulnerability result details</description></item>
        /// <item><description><b>Hc_summary</b>: Baseline check result summary</description></item>
        /// <item><description><b>Cspm_summary</b>: Cloud Security Posture Management (CSPM) result summary</description></item>
        /// <item><description><b>Vul_summary</b>: Vulnerability result summary</description></item>
        /// <item><description><b>Agentless_event</b>: Agentless detection result details</description></item>
        /// <item><description><b>Filedetect_event</b>: Malicious file SDK result details</description></item>
        /// <item><description><b>Rasp_event</b>: Application protection result details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yundun_webguard_event</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <h3>Notification method</h3>
        /// <h4>When BizType is empty</h4>
        /// <list type="bullet">
        /// <item><description>0: disabled</description></item>
        /// <item><description>1: SMS enabled</description></item>
        /// <item><description>2: email enabled</description></item>
        /// <item><description>4: internal message enabled</description></item>
        /// <item><description>3: SMS and email enabled</description></item>
        /// <item><description>5: SMS and internal message enabled</description></item>
        /// <item><description>6: email and internal message enabled</description></item>
        /// <item><description>7: SMS, email, and internal message all enabled</description></item>
        /// </list>
        /// <h4>When BizType is <c>cms</c></h4>
        /// <list type="bullet">
        /// <item><description>0: CloudMonitor push disabled</description></item>
        /// <item><description>1: CloudMonitor push enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Route")]
        [Validation(Required=false)]
        public int? Route { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.178.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <h3>Notification time limit</h3>
        /// <h4>When the BizType field is empty: valid values</h4>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No limit.</description></item>
        /// <item><description><b>1</b>: Notifications are sent only between 08:00 and 22:00.</description></item>
        /// </list>
        /// <h4>When the BizType field is <c>cms</c></h4>
        /// <para>Specifies the push frequency limit, in seconds. The minimum value is <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeLimit")]
        [Validation(Required=false)]
        public int? TimeLimit { get; set; }

    }

}

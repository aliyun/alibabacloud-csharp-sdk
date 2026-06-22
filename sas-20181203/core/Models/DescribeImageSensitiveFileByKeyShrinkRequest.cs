// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSensitiveFileByKeyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The UUID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0083a31ccf7c10367a6e783e8601****</para>
        /// </summary>
        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in paging query. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scan scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b>: Image.</description></item>
        /// <item><description><b>container</b>: Container.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRangeShrink { get; set; }

        /// <summary>
        /// <para>The sensitive file alerting type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>npm_token</b>: NPM access token</description></item>
        /// <item><description><b>ftp_cfg</b>: FTP configuration</description></item>
        /// <item><description><b>google_oauth_key</b>: Google OAuth Key</description></item>
        /// <item><description><b>planetscale_passwd</b>: Planetscale password</description></item>
        /// <item><description><b>github_ssh_key</b>: Github SSH key</description></item>
        /// <item><description><b>msbuild_publish_profile</b>: MSBuild publish profile</description></item>
        /// <item><description><b>fastly_cdn_token</b>: Fastly CDN token</description></item>
        /// <item><description><b>ssh_private_key</b>: SSH private key</description></item>
        /// <item><description><b>aws_cli</b>: AWS CLI credentials</description></item>
        /// <item><description><b>cpanel_proftpd</b>: cPanel ProFTPd credentials</description></item>
        /// <item><description><b>postgresql_passwd</b>: PostgreSQL password file</description></item>
        /// <item><description><b>discord_client_cred</b>: Discord client credentials</description></item>
        /// <item><description><b>rails_database</b>: Rails database configuration</description></item>
        /// <item><description><b>aws_access_key</b>: AWS Access Key</description></item>
        /// <item><description><b>esmtp_cfg</b>: ESMTP mail server configuration</description></item>
        /// <item><description><b>docker_registry_cfg</b>: Docker image repository configuration</description></item>
        /// <item><description><b>pem</b>: PEM</description></item>
        /// <item><description><b>common_cred</b>: common credentials</description></item>
        /// <item><description><b>sftp_cfg</b>: SFTP connection configuration</description></item>
        /// <item><description><b>grafana_token</b>: Grafana token</description></item>
        /// <item><description><b>slack_token</b>: Slack Token</description></item>
        /// <item><description><b>ec_private_key</b>: EC private key</description></item>
        /// <item><description><b>pypi_token</b>: PyPI upload token</description></item>
        /// <item><description><b>finicity_token</b>: Finicity platform token</description></item>
        /// <item><description><b>k8s_client_key</b>: Kubernetes client private key</description></item>
        /// <item><description><b>git_cfg</b>: Git configuration</description></item>
        /// <item><description><b>django_key</b>: Django key</description></item>
        /// <item><description><b>jenkins_ssh</b>: Jenkins SSH configuration file</description></item>
        /// <item><description><b>openssh_private_key</b>: OPENSSH private key</description></item>
        /// <item><description><b>square_oauth</b>: Square OAuth credentials</description></item>
        /// <item><description><b>typeform_token</b>: Typeform token</description></item>
        /// <item><description><b>common_database_cfg</b>: common database connection configuration</description></item>
        /// <item><description><b>wordpress_database_cfg</b>: WordPress database configuration</description></item>
        /// <item><description><b>googlecloud_api_key</b>: Google Cloud API Key</description></item>
        /// <item><description><b>vscode_sftp</b>: VSCode SFTP configuration</description></item>
        /// <item><description><b>apache_htpasswd</b>: Apache htpasswd</description></item>
        /// <item><description><b>planetscale_token</b>: Planetscale token</description></item>
        /// <item><description><b>contentful_preview_token</b>: Contentful Preview token</description></item>
        /// <item><description><b>php_database_cfg</b>: PHP application database password</description></item>
        /// <item><description><b>atom_remote_sync</b>: Atom remote synchronization configuration</description></item>
        /// <item><description><b>aws_session_token</b>: AWS session token</description></item>
        /// <item><description><b>atom_sftp_cfg</b>: Atom SFTP configuration</description></item>
        /// <item><description><b>asana_client_private_key</b>: Asana client private key</description></item>
        /// <item><description><b>tencentcloud_ak</b>: third-party cloud SecretId</description></item>
        /// <item><description><b>rsa_private_key</b>: RSA private key</description></item>
        /// <item><description><b>github_personal_token</b>: Github Personal access token</description></item>
        /// <item><description><b>pgp</b>: PGP encrypt file</description></item>
        /// <item><description><b>stripe_skpk</b>: Stripe Secret Key</description></item>
        /// <item><description><b>square_token</b>: Square access token</description></item>
        /// <item><description><b>rails_carrierwave</b>: Rails Carrierwave file upload credentials</description></item>
        /// <item><description><b>dbeaver_database_cfg</b>: DBeaver database configuration</description></item>
        /// <item><description><b>robomongo_cred</b>: Robomongo credentials</description></item>
        /// <item><description><b>github_oauth_token</b>: Github OAuth access token</description></item>
        /// <item><description><b>pulumi_token</b>: Pulumi token</description></item>
        /// <item><description><b>ventrilo_voip</b>: Ventrilo VoIP Server configuration</description></item>
        /// <item><description><b>macos_keychain</b>: macOS Keychain</description></item>
        /// <item><description><b>amazon_mws_token</b>: Amazon MWS Token</description></item>
        /// <item><description><b>dynatrace_token</b>: Dynatrace token</description></item>
        /// <item><description><b>java_keystore</b>: Java KeyStore</description></item>
        /// <item><description><b>microsoft_sdf</b>: Microsoft SQL CE database</description></item>
        /// <item><description><b>kubernetes_dashboard_cred</b>: Kubernetes Dashboard user credentials</description></item>
        /// <item><description><b>atlassian_token</b>: Atlassian token</description></item>
        /// <item><description><b>rdp</b>: Remote Desktop Protocol (RDP) connection</description></item>
        /// <item><description><b>mailgun_key</b>: Mailgun Webhook Signing Key</description></item>
        /// <item><description><b>mailchimp_api_key</b>: Mailchimp API Key</description></item>
        /// <item><description><b>netrc_cfg</b>: .netrc configuration file</description></item>
        /// <item><description><b>openvpn_cfg</b>: OpenVPN client configuration</description></item>
        /// <item><description><b>github_refresh_token</b>: Github Refresh Token</description></item>
        /// <item><description><b>salesforce</b>: Salesforce credentials</description></item>
        /// <item><description><b>sendinblue</b>: Sendinblue token</description></item>
        /// <item><description><b>pkcs_private_key</b>: PKCS#12 key</description></item>
        /// <item><description><b>rubyonrails_passwd</b>: Ruby on Rails password file</description></item>
        /// <item><description><b>filezilla_ftp</b>: FileZilla FTP configuration</description></item>
        /// <item><description><b>databricks_token</b>: Databricks token</description></item>
        /// <item><description><b>gitLab_personal_token</b>: GitLab Personal access token</description></item>
        /// <item><description><b>rails_master_key</b>: Rails Master Key</description></item>
        /// <item><description><b>sqlite</b>: SQLite3/SQLite database</description></item>
        /// <item><description><b>firefox_logins</b>: Firefox logon configuration</description></item>
        /// <item><description><b>mailgun_private_token</b>: Mailgun Private token</description></item>
        /// <item><description><b>joomla_cfg</b>: Joomla configuration</description></item>
        /// <item><description><b>hashicorp_terraform_token</b>: Hashicorp Terraform Token</description></item>
        /// <item><description><b>jetbrains_ides</b>: Jetbrains IDEs configuration</description></item>
        /// <item><description><b>heroku_api_key</b>: Heroku API key</description></item>
        /// <item><description><b>messagebird_token</b>: MessageBird token</description></item>
        /// <item><description><b>github_app_token</b>: Github App Token</description></item>
        /// <item><description><b>hashicorp_vault_token</b>: Hashicorp Vault Token</description></item>
        /// <item><description><b>pgp_private_key</b>: PGP private key</description></item>
        /// <item><description><b>sshpasswd</b>: SSH password</description></item>
        /// <item><description><b>huaweicloud_ak</b>: third-party cloud Secret Access Key</description></item>
        /// <item><description><b>aws_s3cmd</b>: AWS S3cmd configuration</description></item>
        /// <item><description><b>php_config</b>: PHP configuration</description></item>
        /// <item><description><b>common_private_key</b>: common private key types</description></item>
        /// <item><description><b>microsoft_mdf</b>: Microsoft SQL database</description></item>
        /// <item><description><b>mediawiki_cfg</b>: MediaWiki configuration</description></item>
        /// <item><description><b>jenkins_cred</b>: Jenkins credentials</description></item>
        /// <item><description><b>rubygems_cred</b>: Rubygems credentials</description></item>
        /// <item><description><b>clojars_token</b>: Clojars token</description></item>
        /// <item><description><b>phoenix_web_passwd</b>: Phoenix Web credentials</description></item>
        /// <item><description><b>puttygen_private_key</b>: PuTTYgen private key</description></item>
        /// <item><description><b>google_oauth_token</b>: Google OAuth access token</description></item>
        /// <item><description><b>rubyonrails_cfg</b>: Ruby On Rails database configuration</description></item>
        /// <item><description><b>lob_api_key</b>: Lob API Key</description></item>
        /// <item><description><b>pkcs_cred</b>: PKCS#12 certificate</description></item>
        /// <item><description><b>otr_private_key</b>: OTR private key</description></item>
        /// <item><description><b>contentful_delivery_token</b>: Contentful Delivery token</description></item>
        /// <item><description><b>digital_ocean_tugboat</b>: Digital Ocean Tugboat configuration</description></item>
        /// <item><description><b>dsa_private_key</b>: DSA private key</description></item>
        /// <item><description><b>rails_app_token</b>: Rails App token</description></item>
        /// <item><description><b>git_cred</b>: Git user credentials</description></item>
        /// <item><description><b>newrelic_api_key</b>: New Relic User API Key</description></item>
        /// <item><description><b>github_hub</b>: hub configuration that stores Github tokens</description></item>
        /// <item><description><b>rubygem</b>: Rubygem token</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>google_oauth_key</para>
        /// </summary>
        [NameInMap("SensitiveFileKey")]
        [Validation(Required=false)]
        public string SensitiveFileKey { get; set; }

    }

}
